﻿using System;
using System.Collections.Generic;
using System.IO;
using ProtoBuf;

namespace Eb
{
    public abstract class RpcSlotBase
    {
        //---------------------------------------------------------------------
        public abstract void onRpcMethod(byte[] buf);
    }

    public class RpcSlot : RpcSlotBase
    {
        //---------------------------------------------------------------------
        public Action action;

        //---------------------------------------------------------------------
        public RpcSlot(Action a)
        {
            action = a;
        }

        //---------------------------------------------------------------------
        public override void onRpcMethod(byte[] buf)
        {
            action();
        }
    }

    public class RpcSlot<T1> : RpcSlotBase
    {
        //---------------------------------------------------------------------
        public Action<T1> action;

        //---------------------------------------------------------------------
        public RpcSlot(Action<T1> a)
        {
            action = a;
        }

        //---------------------------------------------------------------------
        public override void onRpcMethod(byte[] buf)
        {
            if (buf == null)
            {
                EbLog.Error("RpcSlot.onRpcMethod() Buf==null! Method=" + action.Method.Name);
                EbLog.Error("Type1=" + typeof(T1).Name);
                return;
            }

            using (MemoryStream s = new MemoryStream(buf))
            {
                try
                {
                    var t1 = ProtoBuf.Serializer.Deserialize<T1>(s);

                    action(t1);
                }
                catch (Exception ex)
                {
                    EbLog.Error("RpcSlot.onRpcMethod() Serializer Error! Method=" + action.Method.Name + " Exception:" + ex.ToString());
                    EbLog.Error("Type1=" + typeof(T1).Name);
                }
            }
        }
    }

    public class RpcSlot<T1, T2> : RpcSlotBase
    {
        //---------------------------------------------------------------------
        public Action<T1, T2> action;

        //---------------------------------------------------------------------
        public RpcSlot(Action<T1, T2> a)
        {
            action = a;
        }

        //---------------------------------------------------------------------
        public override void onRpcMethod(byte[] buf)
        {
            if (buf == null || buf.Length == 0)
            {
                EbLog.Error("RpcSlot.onRpcMethod() Buf==null! Method=" + action.Method.Name);
                EbLog.Error("Type1=" + typeof(T1).Name + " Type2=" + typeof(T2));
                return;
            }

            using (MemoryStream s = new MemoryStream(buf))
            {
                try
                {
                    var t1 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T1>(s, ProtoBuf.PrefixStyle.Fixed32);
                    var t2 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T2>(s, ProtoBuf.PrefixStyle.Fixed32);

                    action(t1, t2);
                }
                catch (Exception ex)
                {
                    EbLog.Error("RpcSlot.onRpcMethod() Serializer Error! Method=" + action.Method.Name + " Exception:" + ex.ToString());
                    EbLog.Error("Type1=" + typeof(T1).Name + " Type2=" + typeof(T2));
                }
            }
        }
    }

    public class RpcSlot<T1, T2, T3> : RpcSlotBase
    {
        //---------------------------------------------------------------------
        public Action<T1, T2, T3> action;

        //---------------------------------------------------------------------
        public RpcSlot(Action<T1, T2, T3> a)
        {
            action = a;
        }

        //---------------------------------------------------------------------
        public override void onRpcMethod(byte[] buf)
        {
            if (buf == null || buf.Length == 0)
            {
                EbLog.Error("RpcSlot.onRpcMethod() Buf==null! Method=" + action.Method.Name);
                EbLog.Error("Type1=" + typeof(T1).Name + " Type2=" + typeof(T2) + " Type3=" + typeof(T3));
                return;
            }

            using (MemoryStream s = new MemoryStream(buf))
            {
                try
                {
                    var t1 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T1>(s, ProtoBuf.PrefixStyle.Fixed32);
                    var t2 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T2>(s, ProtoBuf.PrefixStyle.Fixed32);
                    var t3 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T3>(s, ProtoBuf.PrefixStyle.Fixed32);

                    action(t1, t2, t3);
                }
                catch (Exception ex)
                {
                    EbLog.Error("RpcSlot.onRpcMethod() Serializer Error! Method=" + action.Method.Name + " Exception:" + ex.ToString());
                    EbLog.Error("Type1=" + typeof(T1).Name + " Type2=" + typeof(T2) + " Type3=" + typeof(T3));
                }
            }
        }
    }

    public class RpcSlot<T1, T2, T3, T4> : RpcSlotBase
    {
        //---------------------------------------------------------------------
        public Action<T1, T2, T3, T4> action;

        //---------------------------------------------------------------------
        public RpcSlot(Action<T1, T2, T3, T4> a)
        {
            action = a;
        }

        //---------------------------------------------------------------------
        public override void onRpcMethod(byte[] buf)
        {
            if (buf == null || buf.Length == 0)
            {
                EbLog.Error("RpcSlot.onRpcMethod() Buf==null! Method=" + action.Method.Name);
                EbLog.Error("Type1=" + typeof(T1).Name + " Type2=" + typeof(T2) + " Type3=" + typeof(T3) + " Type4=" + typeof(T4));
                return;
            }

            using (MemoryStream s = new MemoryStream(buf))
            {
                try
                {
                    var t1 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T1>(s, ProtoBuf.PrefixStyle.Fixed32);
                    var t2 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T2>(s, ProtoBuf.PrefixStyle.Fixed32);
                    var t3 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T3>(s, ProtoBuf.PrefixStyle.Fixed32);
                    var t4 = ProtoBuf.Serializer.DeserializeWithLengthPrefix<T4>(s, ProtoBuf.PrefixStyle.Fixed32);

                    action(t1, t2, t3, t4);
                }
                catch (Exception ex)
                {
                    EbLog.Error("RpcSlot.onRpcMethod() Serializer Error! Method=" + action.Method.Name + " Exception:" + ex.ToString());
                    EbLog.Error("Type1=" + typeof(T1).Name + " Type2=" + typeof(T2) + " Type3=" + typeof(T3) + " Type4=" + typeof(T4));
                }
            }
        }
    }

    public sealed class RpcCallee
    {
        //---------------------------------------------------------------------
        // key=method_id
        Dictionary<ushort, RpcSlotBase> mMapRpcSlot = new Dictionary<ushort, RpcSlotBase>();

        //---------------------------------------------------------------------
        internal void _onRpcMethod(IRpcSession session, ushort method_id, byte[] data)
        {
            RpcSlotBase rpc_slot = null;
            mMapRpcSlot.TryGetValue(method_id, out rpc_slot);
            if (rpc_slot == null)
            {
                EbLog.Error("RpcCallee._onRpcMethod() not found method_id. method_id = " + method_id);
                return;
            }

            rpc_slot.onRpcMethod(data);
        }

        //---------------------------------------------------------------------
        internal void _defRpcMethod(ushort method_id, Action a)
        {
            RpcSlot rpc_slot = new RpcSlot(a);
            mMapRpcSlot[method_id] = rpc_slot;
        }

        //---------------------------------------------------------------------
        internal void _defRpcMethod<T1>(ushort method_id, Action<T1> a)
        {
            RpcSlot<T1> rpc_slot = new RpcSlot<T1>(a);
            mMapRpcSlot[method_id] = rpc_slot;
        }

        //---------------------------------------------------------------------
        internal void _defRpcMethod<T1, T2>(ushort method_id, Action<T1, T2> a)
        {
            RpcSlot<T1, T2> rpc_slot = new RpcSlot<T1, T2>(a);
            mMapRpcSlot[method_id] = rpc_slot;
        }

        //---------------------------------------------------------------------
        internal void _defRpcMethod<T1, T2, T3>(ushort method_id, Action<T1, T2, T3> a)
        {
            RpcSlot<T1, T2, T3> rpc_slot = new RpcSlot<T1, T2, T3>(a);
            mMapRpcSlot[method_id] = rpc_slot;
        }

        //---------------------------------------------------------------------
        internal void _defRpcMethod<T1, T2, T3, T4>(ushort method_id, Action<T1, T2, T3, T4> a)
        {
            RpcSlot<T1, T2, T3, T4> rpc_slot = new RpcSlot<T1, T2, T3, T4>(a);
            mMapRpcSlot[method_id] = rpc_slot;
        }

        //---------------------------------------------------------------------
        internal void _clear()
        {
            mMapRpcSlot.Clear();
        }
    }
}
