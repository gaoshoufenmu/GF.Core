//using System;
//using System.Collections;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using RabbitMQ.Client;
//using RabbitMQ.Client.Events;
//using Eb;

//namespace Es
//{
//    class EsEngineRabbitMQ : IBasicConsumer, IRpcCallerMQ
//    {
//        //-------------------------------------------------------------------------
//        struct RecvData
//        {
//            public string que_name;
//            public byte[] data;
//        }

//        //-------------------------------------------------------------------------
//        public event EventHandler<ConsumerEventArgs> ConsumerCancelled;
//        ConnectionFactory mMQConnectionFactroy;
//        IConnection mMQConnection;
//        IModel mMQChannel;
//        ConcurrentQueue<RecvData> mQueRecvData = new ConcurrentQueue<RecvData>();

//        //-------------------------------------------------------------------------
//        public EntityMgr EntityMgr { get; private set; }
//        public IConnection MQConnection { get { return mMQConnection; } }
//        public IModel Model { get { return mMQChannel; } }
//        public string NodeMQ { get { return EsEngine.Instance.NodeMQ; } }

//        //-------------------------------------------------------------------------
//        public void create(EntityMgr entity_mgr, string host_name, int port,
//            string user_name, string pwd, string virtual_host)
//        {
//            EbLog.Note("EsEngineRabbitMQ.create()");

//            EntityMgr = entity_mgr;

//            //if (mMQConnectionFactroy == null)
//            //{
//            //    mMQConnectionFactroy = new ConnectionFactory();

//            //    mMQConnectionFactroy.HostName = host_name;
//            //    mMQConnectionFactroy.Port = port;
//            //    mMQConnectionFactroy.UserName = user_name;
//            //    mMQConnectionFactroy.Password = pwd;
//            //    mMQConnectionFactroy.VirtualHost = virtual_host;

//            //    mMQConnectionFactroy.RequestedHeartbeat = 60;
//            //    mMQConnectionFactroy.AutomaticRecoveryEnabled = true;
//            //    mMQConnectionFactroy.TopologyRecoveryEnabled = true;
//            //    mMQConnectionFactroy.NetworkRecoveryInterval = TimeSpan.FromSeconds(5);

//            //    mMQConnection = mMQConnectionFactroy.CreateConnection();

//            //    EbLog.Note("--------RabbitMQ Begin-------");
//            //    EbLog.Note("RabbitMQ HostName=" + host_name + " Port=" + port);
//            //    EbLog.Note("RabbitMQ UserName=" + user_name + " Password=" + pwd);
//            //    EbLog.Note("RabbitMQ VirtualHost=" + virtual_host);
//            //    EbLog.Note("--------RabbitMQ End----------");
//            //}

//            //mMQChannel = mMQConnection.CreateModel();
//        }

//        //-------------------------------------------------------------------------
//        public void destroy()
//        {
//            //if (mMQChannel != null)
//            //{
//            //    mMQChannel.Close();
//            //    mMQChannel.Dispose();
//            //    mMQChannel = null;
//            //}

//            //if (mMQConnection != null)
//            //{
//            //    mMQConnection.Close();
//            //    mMQConnection.Dispose();
//            //    mMQConnection = null;
//            //}

//            //mMQConnectionFactroy = null;

//            EbLog.Note("EsEngineRabbitMQ.destroy()");
//        }

//        //-------------------------------------------------------------------------
//        public void update(float elapsed_tm)
//        {
//            //while (!mQueRecvData.IsEmpty)
//            //{
//            //    RecvData recv_data;
//            //    if (mQueRecvData.TryDequeue(out recv_data))
//            //    {
//            //        using (MemoryStream s = new MemoryStream(recv_data.data))
//            //        {
//            //            RpcData rpc_data = ProtoBuf.Serializer.Deserialize<RpcData>(s);

//            //            string rpc_guid = null;
//            //            if (rpc_data.cmd == (byte)_eRpcCmd.EntityMethod)
//            //            {
//            //                string[] l = recv_data.que_name.Split('.');
//            //                rpc_guid = l[1];
//            //            }

//            //            //EbLog.Note("exchange: " + recv_data.exchange);
//            //            //EbLog.Note("route_key: " + recv_data.routing_key);
//            //            //EbLog.Note("rpc_guid: " + rpc_guid);
//            //            EntityMgr.onRecvRpcData(rpc_guid, rpc_data, recv_data.data);
//            //        }
//            //    }
//            //}
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
//            //RecvData recv_data;
//            //recv_data.que_name = consumerTag;
//            //recv_data.data = body;
//            //mQueRecvData.Enqueue(recv_data);
//        }

//        //-------------------------------------------------------------------------
//        public void HandleModelShutdown(object model, ShutdownEventArgs reason)
//        {
//        }

//        //---------------------------------------------------------------------
//        public void newLocalQue(string rpc_guid, string exchange_type)
//        {
//            //if (mMQChannel == null) return;

//            //string src_id = "rpc." + rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //mMQChannel.QueueDeclareNoWait(src_id, false, false, false, null);
//            //mMQChannel.ExchangeDeclareNoWait(src_id, exchange_type, false, false, null);
//            //mMQChannel.BasicConsume(src_id, true, src_id, this);
//        }

//        //---------------------------------------------------------------------
//        public void deleteLocalQue(string rpc_guid)
//        {
//            //if (mMQChannel == null) return;

//            //string src_id = "rpc." + rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //mMQChannel.QueueDeleteNoWait(src_id, false, true);
//            //mMQChannel.ExchangeDeleteNoWait(src_id, false);
//        }

//        //---------------------------------------------------------------------
//        public void bindRemoteQue(string rpc_guid, byte to_node)
//        {
//            //if (mMQChannel == null) return;

//            //string src_id = "rpc." + rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //string dst_id = "rpc." + rpc_guid + "." + to_node.ToString();

//            //mMQChannel.QueueDeclareNoWait(dst_id, false, false, false, null);
//            //mMQChannel.QueueBindNoWait(dst_id, src_id, dst_id, null);
//        }

//        //---------------------------------------------------------------------
//        public void unbindRemoteQue(string rpc_guid, byte to_node)
//        {
//            //if (mMQChannel == null) return;

//            //string src_id = "rpc." + rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //string dst_id = "rpc." + rpc_guid + "." + to_node.ToString();

//            //mMQChannel.ExchangeUnbindNoWait(dst_id, src_id, dst_id, null);
//        }

//        //---------------------------------------------------------------------
//        public void bindRemoteQue4Broadcast(string src_rpc_guid, string rpc_guid, byte route_node)
//        {
//            //if (mMQChannel == null) return;

//            //string src_id = "rpc." + src_rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //string dst_id = "rpc." + rpc_guid + "." + route_node.ToString();

//            //mMQChannel.QueueDeclareNoWait(dst_id, false, false, false, null);
//            //mMQChannel.QueueBindNoWait(dst_id, src_id, dst_id, null);
//        }

//        //---------------------------------------------------------------------
//        public void unbindRemoteQue4Broadcast(string src_rpc_guid, string rpc_guid, byte route_node)
//        {
//            //if (mMQChannel == null) return;

//            //string src_id = "rpc." + src_rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //string dst_id = "rpc." + rpc_guid + "." + route_node.ToString();

//            //mMQChannel.ExchangeUnbindNoWait(dst_id, src_id, dst_id, null);
//        }

//        //---------------------------------------------------------------------
//        public void rpc(byte route_node, string rpc_guid, RpcData rpc_data)
//        {
//            //if (mMQChannel == null) return;

//            //byte[] buf = null;
//            //using (MemoryStream s = new MemoryStream())
//            //{
//            //    ProtoBuf.Serializer.Serialize<RpcData>(s, rpc_data);
//            //    buf = s.ToArray();
//            //}

//            //string src_id = "rpc." + rpc_guid + "." + EntityMgr.NodeType.ToString();
//            //string dst_id = "rpc." + rpc_guid + "." + route_node.ToString();

//            //mMQChannel.BasicPublish(src_id, dst_id, null, buf);
//        }

//        //---------------------------------------------------------------------
//        public void rpcNode(string dst_nodemq, RpcData rpc_data)
//        {
//            //if (mMQChannel == null) return;

//            //byte[] buf = null;
//            //using (MemoryStream s = new MemoryStream())
//            //{
//            //    ProtoBuf.Serializer.Serialize<RpcData>(s, rpc_data);
//            //    buf = s.ToArray();
//            //}

//            //mMQChannel.QueueDeclareNoWait(dst_nodemq, false, false, false, null);
//            //mMQChannel.QueueBindNoWait(dst_nodemq, NodeMQ, dst_nodemq, null);
//            //mMQChannel.BasicPublish(NodeMQ, dst_nodemq, null, buf);
//        }

//        //---------------------------------------------------------------------
//        public void rpcBroadcast(string rpc_guid, RpcData rpc_data)
//        {
//            //if (mMQChannel == null) return;

//            //byte[] buf = null;
//            //using (MemoryStream s = new MemoryStream())
//            //{
//            //    ProtoBuf.Serializer.Serialize<RpcData>(s, rpc_data);
//            //    buf = s.ToArray();
//            //}

//            //string src_id = "rpc." + rpc_guid + "." + EntityMgr.NodeType.ToString();

//            //mMQChannel.BasicPublish(src_id, "#", null, buf);
//        }

//        //-------------------------------------------------------------------------
//        public void createNodeMQ()
//        {
//            //if (mMQChannel == null) return;

//            //// 创建进程实例队列
//            //string node_mq = EsEngine.Instance.NodeMQ;
//            //mMQChannel.QueueDeclareNoWait(node_mq, false, false, false, null);
//            //mMQChannel.ExchangeDeclareNoWait(node_mq, ExchangeType.Direct, false, false, null);
//            //mMQChannel.BasicConsume(node_mq, true, this);

//            //EbLog.Note("EsEngineRabbitMQ.createNodeMQ() NodeMQ=" + node_mq);
//        }
//    }
//}
