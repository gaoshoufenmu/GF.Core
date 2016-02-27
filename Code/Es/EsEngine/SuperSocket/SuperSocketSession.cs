using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using SuperSocket.SocketBase;
using SuperSocket.ProtoBase;
using Eb;

namespace Es
{
    public enum SessionCloseReason
    {
        Unknown = 0,
        ServerShutdown = 1,
        ClientClosing = 2,
        ServerClosing = 3,
        ApplicationError = 4,
        SocketError = 5,
        TimeOut = 6,
        ProtocolError = 7,
        InternalError = 8,
    }

    enum eSocketEventType
    {
        Null = 0,
        Connected,
        Closed,
        Error,
        UnknownRequest,
    }

    struct SocketEvent
    {
        public eSocketEventType type;
        public object args;
    }

    public delegate void OnSocketReceive(byte[] data);
    public delegate void OnSocketConnected();
    public delegate void OnSocketClosed(SessionCloseReason reason);
    public delegate void OnSocketError(string error);

    public class SuperSocketSession : AppSession<SuperSocketSession, BufferedPackageInfo<ushort>, ushort>
    {
        //---------------------------------------------------------------------
        ConcurrentQueue<byte[]> mReceiveQueue = new ConcurrentQueue<byte[]>();
        ConcurrentQueue<SocketEvent> mSocketEvent = new ConcurrentQueue<SocketEvent>();
        object mLockWorker = new object();
        public bool IsConnected { get; set; }

        //---------------------------------------------------------------------
        public OnSocketConnected OnSocketConnected { get; set; }
        public OnSocketClosed OnSocketClosed { get; set; }
        public OnSocketReceive OnSocketReceive { get; set; }
        public OnSocketError OnSocketError { get; set; }
        public object UserData { get; set; }

        //---------------------------------------------------------------------
        public new SuperSocketServer AppServer
        {
            get { return (SuperSocketServer)base.AppServer; }
        }

        //---------------------------------------------------------------------
        public void send(ushort method_id, byte[] data)
        {
            ushort data_len = 0;
            byte[] send_buf = null;
            if (data == null)
            {
                data_len = sizeof(ushort);
                send_buf = new byte[sizeof(ushort) + data_len];
            }
            else
            {
                data_len = (ushort)(sizeof(ushort) + data.Length);
                send_buf = new byte[sizeof(ushort) + data_len];
            }
            Array.Copy(BitConverter.GetBytes(data_len), 0, send_buf, 0, sizeof(ushort));
            Array.Copy(BitConverter.GetBytes(method_id), 0, send_buf, sizeof(ushort), sizeof(ushort));
            if (data != null && data.Length > 0) Array.Copy(data, 0, send_buf, sizeof(ushort) + sizeof(ushort), data.Length);
            Send(send_buf, 0, send_buf.Length);
        }

        //---------------------------------------------------------------------
        public void send(byte[] buf)
        {
            send(buf, 0, (ushort)buf.Length);
        }

        //---------------------------------------------------------------------
        public void send(byte[] buf, ushort length)
        {
            send(buf, 0, length);
        }

        //---------------------------------------------------------------------
        public void send(byte[] buf, int offset, ushort length)
        {
            byte[] send_buf = new byte[length + 2];
            byte[] body_length = BitConverter.GetBytes(length);
            Array.Copy(body_length, 0, send_buf, 0, 2);
            Array.Copy(buf, offset, send_buf, 2, length);
            Send(send_buf, 0, send_buf.Length);
        }

        //---------------------------------------------------------------------
        public void close()
        {
            Close(CloseReason.ServerClosing);
        }

        //---------------------------------------------------------------------
        public void update()
        {
            SocketEvent socket_event;
            socket_event.type = eSocketEventType.Null;
            socket_event.args = null;
            while (mSocketEvent.TryDequeue(out socket_event))
            {
                _processSocketEvent(socket_event.type, socket_event.args);
            }

            byte[] data;
            while (mReceiveQueue.TryDequeue(out data))
            {
                if (OnSocketReceive != null)
                {
                    OnSocketReceive(data);
                }
            }
        }

        //---------------------------------------------------------------------
        protected override void OnSessionStarted()
        {
            lock (mLockWorker)
            {
                SocketEvent socket_event;
                socket_event.type = eSocketEventType.Connected;
                socket_event.args = null;
                mSocketEvent.Enqueue(socket_event);
            }
        }

        //---------------------------------------------------------------------
        protected override void HandleException(Exception e)
        {
            lock (mLockWorker)
            {
                SocketEvent socket_event;
                socket_event.type = eSocketEventType.Error;
                socket_event.args = e;
                mSocketEvent.Enqueue(socket_event);
            }
        }

        //---------------------------------------------------------------------
        protected override void HandleUnknownRequest(BufferedPackageInfo<ushort> packet)
        {
            lock (mLockWorker)
            {
                SocketEvent socket_event;
                socket_event.type = eSocketEventType.UnknownRequest;
                socket_event.args = null;
                mSocketEvent.Enqueue(socket_event);
            }
        }

        //---------------------------------------------------------------------
        protected override void OnSessionClosed(CloseReason reason)
        {
            lock (mLockWorker)
            {
                SessionCloseReason r = (SessionCloseReason)reason;
                SocketEvent socket_event;
                socket_event.type = eSocketEventType.Closed;
                socket_event.args = r;
                mSocketEvent.Enqueue(socket_event);
            }
        }

        //---------------------------------------------------------------------
        internal void _onSocketRecv(BufferedPackageInfo<ushort> package)
        {
            lock (mLockWorker)
            {
                byte[] data = new byte[package.Key];
                _copyTo(package.Data, data, 0, package.Key);
                mReceiveQueue.Enqueue(data);
            }
        }

        //---------------------------------------------------------------------
        void _processSocketEvent(eSocketEventType type, object args)
        {
            switch (type)
            {
                case eSocketEventType.Connected:
                    {
                        if (OnSocketConnected != null)
                        {
                            OnSocketConnected();
                        }
                    }
                    break;
                case eSocketEventType.Closed:
                    {
                        SessionCloseReason reason = (SessionCloseReason)args;
                        if (OnSocketClosed != null)
                        {
                            SessionCloseReason r = (SessionCloseReason)reason;
                            OnSocketClosed(r);
                        }
                    }
                    break;
                case eSocketEventType.Error:
                    {
                        if (OnSocketError != null)
                        {
                            OnSocketError(args.ToString());
                        }
                    }
                    break;
                case eSocketEventType.UnknownRequest:
                    {
                        if (OnSocketError != null)
                        {
                            OnSocketError("HandleUnknownRequest");
                        }
                    }
                    break;
            }
        }

        //---------------------------------------------------------------------
        // Copies data of data segment list to a data segment.
        // <param name="packageData">The source segments data.</param>
        // <param name="data">The destination segment.</param>
        // <param name="srcOffset">The source offset.</param>
        // <param name="length">The length.</param>
        void _copyTo(IList<ArraySegment<byte>> package_data, byte[] data, int src_offset, int length)
        {
            var inner_offset = src_offset;
            var rest_length = length;
            var dest_cur_index = 0;

            for (var i = 0; i < package_data.Count; i++)
            {
                var segment = package_data[i];

                int cur_segment_len = 0;
                if (segment.Count <= inner_offset)
                {
                    inner_offset -= segment.Count;
                    continue;
                }

                cur_segment_len = segment.Count - inner_offset;

                var this_length = Math.Min(rest_length, cur_segment_len);
                Array.Copy(segment.Array, segment.Offset + inner_offset, data, dest_cur_index, this_length);

                inner_offset = 0;

                dest_cur_index += this_length;
                rest_length -= this_length;

                if (rest_length <= 0) break;
            }
        }
    }
}
