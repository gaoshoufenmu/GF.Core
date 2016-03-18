using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using GF.Common;

namespace GF.Server
{
    public class ServerSuperSocket<TDef> : Component<TDef>, ISuperServerListener where TDef : DefSuperSocket, new()
    {
        //---------------------------------------------------------------------
        SuperSocketServer mServer;

        //---------------------------------------------------------------------
        public delegate void OnSuperSocketSessionCreate(IRpcSession s, IPEndPoint remote_endpoint);
        public delegate void OnSuperSocketSessionDestroy(IRpcSession s, SessionCloseReason reason);
        public OnSuperSocketSessionCreate OnSessionCreate { get; set; }
        public OnSuperSocketSessionDestroy OnSessionDestroy { get; set; }

        //---------------------------------------------------------------------
        public override void init()
        {
            EbLog.Note("ServerSuperSocket.init()");

            var settings = EsEngine.Instance.Settings;

            EbLog.Note("ListenIp=" + settings.ListenIp + " ListenPort=" + settings.ListenPort);

            ServerConfig server_config = new ServerConfig();
            server_config.Ip = settings.ListenIp;
            server_config.Port = settings.ListenPort;
            server_config.Mode = SocketMode.Tcp;
            server_config.MaxConnectionNumber = 10000;
            server_config.MaxRequestLength = 40962;
            server_config.ReceiveBufferSize = 40962;
            server_config.DisableSessionSnapshot = true;
            server_config.SyncSend = false;
            server_config.LogAllSocketException = true;
            server_config.LogBasicSessionActivity = true;
            server_config.KeepAliveInterval = 5;
            server_config.KeepAliveTime = 5;

            mServer = new SuperSocketServer(this);

            var r = mServer.Setup(server_config);
            mServer.Start();
        }

        //---------------------------------------------------------------------
        public override void release()
        {
            if (mServer != null)
            {
                mServer.Stop();
                mServer = null;
            }

            EbLog.Note("ServerSuperSocket.release()");
        }

        //---------------------------------------------------------------------
        public override void update(float elapsed_tm)
        {
            if (mServer != null)
            {
                mServer.update();
            }
        }

        //---------------------------------------------------------------------
        public override void handleEvent(object sender, EntityEvent e)
        {
        }

        //-------------------------------------------------------------------------
        public void newSessionConnected(SuperSocketSession s)
        {
            if (OnSessionCreate != null)
            {
                var rs = new EntityRpcSessionSuperSocketS(EntityMgr, s);
                s.UserData = rs;
                OnSessionCreate((IRpcSession)rs, s.RemoteEndPoint);
            }
        }

        //-------------------------------------------------------------------------
        public void sessionClosed(SuperSocketSession s, CloseReason reason)
        {
            if (OnSessionDestroy != null && s.UserData != null)
            {
                SessionCloseReason r = (SessionCloseReason)reason;
                EntityRpcSessionSuperSocketS rs = (EntityRpcSessionSuperSocketS)s.UserData;
                OnSessionDestroy((IRpcSession)rs, r);
            }
        }
    }
}
