using System;
using System.Collections.Generic;
using System.IO;
using Eb;

namespace Es
{
    public class EntityRpcSessionSuperSocketS : IRpcSession
    {
        //---------------------------------------------------------------------
        EntityMgr mEntityMgr;
        SuperSocketSession mSocket;

        //---------------------------------------------------------------------
        public OnSocketConnected OnSocketConnected { get; set; }
        public OnSocketClosed OnSocketClosed { get; set; }
        public OnSocketError OnSocketError { get; set; }
        public bool IsConnected { get { return (mSocket != null) && mSocket.IsConnected; } }
        public string SessionId { get { return mSocket.SessionID; } }

        //---------------------------------------------------------------------
        public EntityRpcSessionSuperSocketS(EntityMgr entity_mgr, SuperSocketSession socket)
        {
            mEntityMgr = entity_mgr;
            mSocket = socket;
            mSocket.OnSocketClosed = _onSocketClose;
            mSocket.OnSocketReceive = _onSocketReceive;
            mSocket.OnSocketError = _onSocketError;
            socket.IsConnected = true;
        }

        //---------------------------------------------------------------------
        public void send(ushort method_id, byte[] data)
        {
            if (mSocket != null)
            {
                mSocket.send(method_id, data);
            }
        }

        //---------------------------------------------------------------------
        public void close()
        {
            if (mSocket != null)
            {
                mSocket.close();
                mSocket = null;
            }
        }

        //---------------------------------------------------------------------
        void _onSocketReceive(byte[] data)
        {
            mEntityMgr.LastRpcSession = this;

            ushort method_id = BitConverter.ToUInt16(data, 0);

            byte[] buf = null;
            if (data.Length > sizeof(ushort))
            {
                ushort data_len = (ushort)(data.Length - sizeof(ushort));
                buf = new byte[data_len];
                Array.Copy(data, sizeof(ushort), buf, 0, data_len);
            }
            else buf = new byte[0];

            mEntityMgr.onRecvRpcData(this, method_id, buf);
        }

        //---------------------------------------------------------------------
        void _onSocketClose(SessionCloseReason reason)
        {
            mSocket = null;

            if (OnSocketClosed != null)
            {
                OnSocketClosed(reason);
            }
        }

        //---------------------------------------------------------------------
        void _onSocketError(string error)
        {
            mSocket = null;

            if (OnSocketError != null)
            {
                OnSocketError(error);
            }
        }
    }
}
