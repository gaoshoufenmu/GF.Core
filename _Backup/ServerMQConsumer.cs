//using System;
//using System.Collections.Generic;
//using System.Text;
//using Eb;

//namespace Es
//{
//    public class ServerMQConsumer<T> : Component<T> where T : DefMQConsumer, new()
//    {
//        //-------------------------------------------------------------------------
//        EsEngineMQConsumer mMQConsumer;

//        //-------------------------------------------------------------------------
//        public override void init()
//        {
//            EnableSerialize = false;

//            mMQConsumer = new EsEngineMQConsumer();
//            mMQConsumer.create(Entity.Guid);

//            EbLog.Note("ServerMQConsumer.init()");
//        }

//        //-------------------------------------------------------------------------
//        public override void release()
//        {
//            mMQConsumer.destroy();
//            mMQConsumer = null;

//            EbLog.Note("ServerMQConsumer.release()");
//        }

//        //-------------------------------------------------------------------------
//        public override void update(float elapsed_tm)
//        {
//            mMQConsumer.update(elapsed_tm);
//        }

//        //-------------------------------------------------------------------------
//        public override void handleEvent(object sender, EntityEvent e)
//        {
//        }

//        //-------------------------------------------------------------------------
//        public void regMQHander(string key, DelegateOnMQRecvData func)
//        {
//            mMQConsumer.regMQHander(key, func);
//        }

//        //-------------------------------------------------------------------------
//        public void send2MQ(string dst_id, string key, string data, bool durable = false)
//        {
//            mMQConsumer.send2MQ(dst_id, key, data, durable);
//        }
//    }
//}

//-------------------------------------------------------------------------
//public void setupMQ(string src_id)
//{
//    SrcId = src_id;
//    mChannel = ((EsEngineRabbitMQ)EsEngine.Instance.RpcCallerMQ).Model;
//    mChannel.QueueDeclareNoWait(SrcId, true, false, false, null);
//    mChannel.ExchangeDeclareNoWait(SrcId, ExchangeType.Direct, true, false, null);
//    mChannel.BasicConsume(SrcId, true, this);
//}

//-------------------------------------------------------------------------
//public void addDstNodeMQ(string dst_id)
//{
//    if (!string.IsNullOrEmpty(SrcId))
//    {
//        mChannel.QueueDeclareNoWait(dst_id, true, false, false, null);
//        mChannel.QueueBindNoWait(dst_id, SrcId, dst_id, null);
//    }
//}

////-------------------------------------------------------------------------
//public void removeDstNodeMQ(string dst_id)
//{
//}

//-------------------------------------------------------------------------
//void _onRecvData1(string exchange, string routing_key, string data)
//
//PlayerOperate operate = EbTool.jsonDeserialize<PlayerOperate>(data);
//switch (operate.player_operate)
//{
//    case _ePlayerOperate.AddFriend:
//        CoPlayer.CoPlayerFriend.checkFriend(operate.map_param);
//        break;
//    case _ePlayerOperate.AddFriendResult:
//        CoPlayer.CoPlayerFriend.addFriendResult(operate.map_param);
//        break;
//    case _ePlayerOperate.DeleteFriend:
//        CoPlayer.CoPlayerFriend.deleteFriend(operate.map_param);
//        break;
//    case _ePlayerOperate.SecreteTalk:
//        CoPlayer.CoPlayerChat.Chat(ChatType.Friend, operate.map_param);
//        break;
//    case _ePlayerOperate.RequestEnterFaction:
//        CoPlayer.requestEnterFaction(operate.map_param);
//        break;
//    case _ePlayerOperate.AgreeEnterFaction:
//        CoPlayer.EnterFactionSeccess(operate.map_param);
//        break;
//    case _ePlayerOperate.RefuseEnterFaction:
//        CoPlayer.EnterFactionFail(operate.map_param);
//        break;
//    case _ePlayerOperate.KickOutFactionMem:
//        CoPlayer.KickOutFaction(operate.map_param);
//        break;
//    case _ePlayerOperate.DissolveFaction:
//        CoPlayer.dissolveFaction(operate.map_param);
//        break;
//    case _ePlayerOperate.FactionTalk:
//        CoPlayer.FactionTalk(operate.map_param);
//        break;
//    case _ePlayerOperate.LevelUpFactionPos:
//        CoPlayer.LevelUpFactionPos(operate.map_param);
//        break;
//}
//}
