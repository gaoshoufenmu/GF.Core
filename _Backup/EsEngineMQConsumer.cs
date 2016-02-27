//using System;
//using System.Collections.Generic;
//using System.Text;
//using RabbitMQ.Client;
//using RabbitMQ.Client.Events;
//using Eb;

//namespace Es
//{
//    public delegate void DelegateOnMQRecvData(string exchange, string routing_key, string data);

//    class EsEngineMQConsumer : IBasicConsumer
//    {
//        //-------------------------------------------------------------------------
//        public struct UserData
//        {
//            public string key;
//            public string data;
//        }

//        public struct MQData
//        {
//            public string exchange;
//            public string routing_key;
//            public string json_str;
//        }

//        //-------------------------------------------------------------------------
//        public event EventHandler<ConsumerEventArgs> ConsumerCancelled;
//        IModel mChannel;
//        Dictionary<string, DelegateOnMQRecvData> mMapDelegateOnRecvData = new Dictionary<string, DelegateOnMQRecvData>();
//        Queue<MQData> mQueData = new Queue<MQData>();
//        object mLockQueData = new object();

//        //-------------------------------------------------------------------------
//        public string SrcId { get; private set; }
//        public IModel Model { get; set; }

//        //-------------------------------------------------------------------------
//        public void create(string src_id)
//        {
//            SrcId = src_id;
//            mChannel = ((EsEngineRabbitMQ)EsEngine.Instance.RpcCallerMQ).Model;
//            mChannel.QueueDeclareNoWait(SrcId, true, false, false, null);
//            mChannel.ExchangeDeclareNoWait(SrcId, ExchangeType.Direct, true, false, null);
//            mChannel.BasicConsume(SrcId, true, this);
//        }

//        //-------------------------------------------------------------------------
//        public void destroy()
//        {
//            mMapDelegateOnRecvData.Clear();

//            if (mChannel != null)
//            {
//                mChannel.Close();
//                mChannel.Dispose();
//                mChannel = null;
//            }
//        }

//        //-------------------------------------------------------------------------
//        public void update(float elapsed_tm)
//        {
//            MQData d;
//            d.exchange = null;
//            d.routing_key = null;
//            d.json_str = null;

//            lock (mLockQueData)
//            {
//                if (mQueData.Count > 0) d = mQueData.Dequeue();
//            }

//            if (string.IsNullOrEmpty(d.json_str)) return;

//            // 处理接收到的数据
//            UserData user_data = EbTool.jsonDeserialize<UserData>(d.json_str);
//            DelegateOnMQRecvData func = null;
//            if (mMapDelegateOnRecvData.TryGetValue(user_data.key, out func))
//            {
//                if (func != null) func(d.exchange, d.routing_key, user_data.data);
//            }
//        }


//        //-------------------------------------------------------------------------
//        public void HandleBasicCancel(string consumerTag)
//        {
//        }

//        //-------------------------------------------------------------------------
//        public void HandleBasicCancelOk(string consumerTag)
//        {
//        }

//        //-------------------------------------------------------------------------
//        public void HandleBasicConsumeOk(string consumerTag)
//        {
//        }

//        //-------------------------------------------------------------------------
//        public void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered,
//            string exchange, string routingKey, IBasicProperties properties, byte[] body)
//        {
//            MQData d;
//            d.exchange = exchange;
//            d.routing_key = routingKey;
//            d.json_str = Encoding.UTF8.GetString(body);

//            lock (mLockQueData)
//            {
//                mQueData.Enqueue(d);
//            }
//        }

//        //-------------------------------------------------------------------------
//        public void HandleModelShutdown(object model, ShutdownEventArgs reason)
//        {
//        }

//        //-------------------------------------------------------------------------
//        public void regMQHander(string key, DelegateOnMQRecvData func)
//        {
//            if (mMapDelegateOnRecvData.ContainsKey(key))
//            {
//                EbLog.Error("ServerMQConsumer.regMQHander Error! Key Exist, Key=" + key);
//                return;
//            }

//            mMapDelegateOnRecvData[key] = func;
//        }

//        //-------------------------------------------------------------------------
//        public void send2MQ(string dst_id, string key, string data, bool durable = false)
//        {
//            if (string.IsNullOrEmpty(SrcId) || string.IsNullOrEmpty(dst_id))
//            {
//                return;
//            }

//            mChannel.QueueDeclareNoWait(dst_id, true, false, false, null);
//            mChannel.QueueBindNoWait(dst_id, SrcId, dst_id, null);

//            UserData user_data;
//            user_data.key = key;
//            user_data.data = data;
//            string json_str = EbTool.jsonSerialize(user_data);
//            mChannel.BasicPublish(SrcId, dst_id, null, Encoding.UTF8.GetBytes(json_str));
//        }
//    }
//}
