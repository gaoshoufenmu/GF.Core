using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using GF.Common;

namespace GF.Server
{
    public class ServerNode<TDef> : Component<TDef> where TDef : DefNode, new()
    {
        //---------------------------------------------------------------------
        public ServerSuperSocket<DefSuperSocket> CoSuperSocket { get; private set; }

        //---------------------------------------------------------------------
        public override void init()
        {
            EbLog.Note("ServerNode.init()");

            var settings = EsEngine.Instance.Settings;

            if (settings.EnableCoSupersocket)
            {
                var et = EntityMgr.createEntity<EtSuperSocket>(null, Entity);
                CoSuperSocket = et.getComponent<ServerSuperSocket<DefSuperSocket>>();
            }
        }

        //---------------------------------------------------------------------
        public override void release()
        {
            EbLog.Note("ServerNode.release()");
        }

        //---------------------------------------------------------------------
        public override void update(float elapsed_tm)
        {
        }

        //---------------------------------------------------------------------
        public override void handleEvent(object sender, EntityEvent e)
        {
        }
    }
}
