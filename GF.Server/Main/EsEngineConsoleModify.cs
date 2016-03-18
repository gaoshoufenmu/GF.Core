using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using GF.Common;

namespace GF.Server
{
    class EsEngineConsoleModify
    {
        //---------------------------------------------------------------------
        enum CtrlType
        {
            CTRL_C_EVENT = 0,
            CTRL_BREAK_EVENT = 1,
            CTRL_CLOSE_EVENT = 2,
            CTRL_LOGOFF_EVENT = 5,
            CTRL_SHUTDOWN_EVENT = 6
        }

        //---------------------------------------------------------------------
        [DllImport("user32.dll ", EntryPoint = "GetSystemMenu")]
        extern static IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);
        [DllImport("user32.dll ", EntryPoint = "RemoveMenu")]
        extern static int RemoveMenu(IntPtr hMenu, int nPos, int flags);
        [DllImport("Kernel32")]
        private static extern bool SetConsoleCtrlHandler(ConsoleCtrlHandler handler, bool add);

        //---------------------------------------------------------------------
        delegate bool ConsoleCtrlHandler(CtrlType sig);
        ConsoleCtrlHandler mConsoleCtrlHandler;
        Thread mThreadMonitorExit;
        ConcurrentQueue<bool> mQueRequest = new ConcurrentQueue<bool>();
        volatile bool mResponseExit;
        string mAppTitle;

        //---------------------------------------------------------------------
        public EsEngineConsoleModify(string app_title)
        {
            mAppTitle = app_title;

            Console.ForegroundColor = ConsoleColor.Green;

            // 禁用“关闭”按钮
            IntPtr CLOSE_MENU = GetSystemMenu(Process.GetCurrentProcess().MainWindowHandle, IntPtr.Zero);
            int SC_CLOSE = 0xF060;
            RemoveMenu(CLOSE_MENU, SC_CLOSE, 0x0);

            mConsoleCtrlHandler = new ConsoleCtrlHandler(_consoleCtrlHandler);
            SetConsoleCtrlHandler(mConsoleCtrlHandler, true);

            if (mThreadMonitorExit == null)
            {
                mThreadMonitorExit = new Thread(new ThreadStart(_threadMonitorExit));
                mThreadMonitorExit.Name = "MonitorExit";
                mThreadMonitorExit.IsBackground = true;
                mThreadMonitorExit.Start();
            }
        }

        //---------------------------------------------------------------------
        public bool canBreak()
        {
            return mResponseExit;
        }

        //---------------------------------------------------------------------
        public void destroy()
        {
            if (mThreadMonitorExit != null)
            {
                mThreadMonitorExit.Join();
                mThreadMonitorExit = null;
            }

            Console.WriteLine("按任意键退出...");
            Console.ReadKey(true);
            //Console.ReadKey(false);
        }

        //---------------------------------------------------------------------
        void _threadMonitorExit()
        {
            while (true)
            {
                if (!mResponseExit && mQueRequest.Count > 0)
                {
                    bool b;
                    while (mQueRequest.Count > 0) mQueRequest.TryDequeue(out b);

                    DialogResult dialog_result = MessageBox.Show("确认退出？", mAppTitle,
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (dialog_result == DialogResult.OK || dialog_result == DialogResult.Yes)
                    {
                        mResponseExit = true;
                        break;
                    }
                }

                Thread.Sleep(100);
            }
        }

        //---------------------------------------------------------------------
        bool _consoleCtrlHandler(CtrlType sig)
        {
            if (sig != CtrlType.CTRL_C_EVENT && mQueRequest.Count == 0)
            {
                mQueRequest.Enqueue(true);
            }

            return true;
        }
    }
}
