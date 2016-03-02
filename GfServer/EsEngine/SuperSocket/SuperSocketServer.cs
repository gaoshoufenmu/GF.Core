using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using SuperSocket.Common;
using SuperSocket.ProtoBase;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketEngine;

namespace Es
{
    struct SessionEvent
    {
        public bool new_or_close;// new:true, close:false
        public SuperSocketSession s;
        public CloseReason reason;
    }

    public interface ISuperServerListener
    {
        //---------------------------------------------------------------------
        void newSessionConnected(SuperSocketSession s);

        //---------------------------------------------------------------------
        void sessionClosed(SuperSocketSession s, CloseReason reason);
    }

    public class SuperSocketServer : AppServer<SuperSocketSession, BufferedPackageInfo<ushort>, ushort>
    {
        //---------------------------------------------------------------------
        ConcurrentQueue<SessionEvent> mQueSessionEvent = new ConcurrentQueue<SessionEvent>();
        ISuperServerListener mListener;

        //---------------------------------------------------------------------
        public SuperSocketServer(ISuperServerListener listener)
            : base()
        {
            mListener = listener;
            NewRequestReceived += _newRequestReceived;
            NewSessionConnected += _newSessionConnected;
            SessionClosed += _sessionClosed;
        }

        //---------------------------------------------------------------------
        public bool Setup(IServerConfig serverConfig)
        {
            return Setup(serverConfig, null,
                new DefaultReceiveFilterFactory<SuperSocketReceiveFilter, BufferedPackageInfo<ushort>>(),
                new SuperSocketLogFactory());
        }

        //---------------------------------------------------------------------
        public void update()
        {
            SessionEvent e;
            e.new_or_close = false;
            e.s = null;
            e.reason = CloseReason.Unknown;
            while (mQueSessionEvent.TryDequeue(out e))
            {
                if (e.new_or_close)
                {
                    mListener.newSessionConnected(e.s);
                }
                else
                {
                    mListener.sessionClosed(e.s, e.reason);
                }
            }

            foreach (var s in GetAllSessions())
            {
                if (s != null && s.IsConnected)
                {
                    s.update();
                }
            }
        }

        //---------------------------------------------------------------------
        void _newRequestReceived(SuperSocketSession session, BufferedPackageInfo<ushort> packet)
        {
            session._onSocketRecv(packet);
        }

        //-------------------------------------------------------------------------
        void _newSessionConnected(SuperSocketSession s)
        {
            SessionEvent e;
            e.new_or_close = true;
            e.s = s;
            e.reason = CloseReason.Unknown;
            mQueSessionEvent.Enqueue(e);
        }

        //-------------------------------------------------------------------------
        void _sessionClosed(SuperSocketSession s, CloseReason reason)
        {
            SessionEvent e;
            e.new_or_close = false;
            e.s = s;
            e.reason = reason;
            mQueSessionEvent.Enqueue(e);
        }
    }
}
