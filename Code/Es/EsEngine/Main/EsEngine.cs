using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Eb;

namespace Es
{
    public struct EsEngineSettings
    {
        public byte NodeType;
        public string NodeTypeString;
        public string ListenIp;
        public int ListenPort;
        public string RootEntityType;
        public bool EnableCoSupersocket;
        public bool EnableCoUCenterSDK;
        public string Log4NetConfigPath;
    }

    public interface IEsEngineListener
    {
        //---------------------------------------------------------------------
        void init(EntityMgr entity_mgr, Entity et_node);

        //---------------------------------------------------------------------
        void release();
    }

    public sealed class EsEngine
    {
        //---------------------------------------------------------------------
        static EsEngine mInstance;
        IEsEngineListener mListener;
        EntityMgr mEntityMgr;
        Stopwatch mStopwatch = new Stopwatch();
        const float mTimeLogicGap = 50.0f;// 毫秒
        ILog mLog;

        //---------------------------------------------------------------------
        public static EsEngine Instance { get { return mInstance; } }
        public EsEngineSettings Settings { get; private set; }
        public Entity EtNode { get; private set; }
        public ServerSuperSocket<DefSuperSocket> CoSuperSocket { get; private set; }
        public ServerUCenterSDK<DefUCenterSDK> CoUCenterSDK { get; private set; }

        //---------------------------------------------------------------------
        public EsEngine(ref EsEngineSettings settings, IEsEngineListener listener)
        {
            mInstance = this;
            mListener = listener;
            Settings = settings;

            // 日志设置
            {
                ILogFactory log_factory = new Log4NetLogFactory(settings.Log4NetConfigPath);
                EbLogFactory.SetLogFactory(log_factory);
                mLog = EbLogFactory.GetLog(this.GetType().Name);

                EbLog.NoteCallback = mLog.Info;
                EbLog.WarningCallback = mLog.Warn;
                EbLog.ErrorCallback = mLog.Error;
            }

            // 处理未捕获的异常
            AppDomain.CurrentDomain.UnhandledException +=
             new UnhandledExceptionEventHandler(_unhandledExceptionEventHandler);

            EbLog.Note("-----------EsEngine启动开始--------------");

            // EntityMgr初始化
            mEntityMgr = new EntityMgr(Settings.NodeType, Settings.NodeTypeString);

            mEntityMgr.regComponent<ServerNode<DefNode>>();
            mEntityMgr.regComponent<ServerSuperSocket<DefSuperSocket>>();
            mEntityMgr.regComponent<ServerUCenterSDK<DefUCenterSDK>>();

            mEntityMgr.regEntityDef<EtNode>();
            mEntityMgr.regEntityDef<EtSuperSocket>();
            mEntityMgr.regEntityDef<EtUCenterSDK>();

            EtNode = mEntityMgr.createEntity<EtNode>(null, null);
            var co_node = EtNode.getComponent<ServerNode<DefNode>>();
            CoSuperSocket = co_node.CoSuperSocket;
            CoUCenterSDK = co_node.CoUCenterSDK;

            EbLog.Note("-----------EsEngine启动完毕--------------");

            // 通知业务层初始化
            if (mListener != null)
            {
                mListener.init(mEntityMgr, EtNode);
            }
        }

        //---------------------------------------------------------------------
        public void run()
        {
            float elapsed_tm = 0f;
            float watch_time = 0f;

            while (true)
            {
                if (Console.KeyAvailable) break;
                mStopwatch.Restart();

                // 每帧更新
                try
                {
                    mEntityMgr.update(elapsed_tm);
                }
                catch (Exception ec)
                {
                    mLog.Error("EsEngine.run() Exception: " + ec);
                }

                mStopwatch.Stop();
                watch_time = mStopwatch.ElapsedMilliseconds;
                if (watch_time > mTimeLogicGap)
                {
                    elapsed_tm = watch_time / 1000.0f;
                    mLog.Warn("EsEngine.run() 每帧时间=" + watch_time
                        + "毫秒，大于设定的每帧固定时间=" + mTimeLogicGap + "毫秒");
                }
                else
                {
                    Thread.Sleep((int)(mTimeLogicGap - watch_time));
                    elapsed_tm = mTimeLogicGap / 1000.0f;
                }
            }

            close();
        }

        //---------------------------------------------------------------------
        public void update(float elapsed_tm)
        {
            try
            {
                mEntityMgr.update(elapsed_tm);
            }
            catch (Exception ec)
            {
                mLog.Error("EsEngine.run() Exception: " + ec);
            }
        }

        //---------------------------------------------------------------------
        public void close()
        {
            // 通知业务层销毁
            if (mListener != null)
            {
                mListener.release();
                mListener = null;
            }

            EbLog.Note("-----------EsEngine销毁开始--------------");

            if (mEntityMgr != null)
            {
                mEntityMgr.destroy();
                mEntityMgr = null;
            }

            EbLog.Note("-----------EsEngine销毁完成--------------");
        }

        //---------------------------------------------------------------------
        static void _unhandledExceptionEventHandler(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                EbLog.Error(e.ExceptionObject.ToString());
            }
            catch
            {
            }
        }
    }
}
