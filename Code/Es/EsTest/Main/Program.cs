using System;
using System.Collections.Generic;
using System.Text;
using Eb;
using Es;

class EsEngineListener : IEsEngineListener
{
    //-------------------------------------------------------------------------
    public void init(EntityMgr entity_mgr, Entity et_node)
    {
        EbLog.Note("EsEngineListener.init()");

        entity_mgr.regComponent<ServerTest<DefTest>>();

        entity_mgr.regEntityDef<EtTest>();

        entity_mgr.createEntity<EtTest>(null, et_node);
    }

    //-------------------------------------------------------------------------
    public void release()
    {
        EbLog.Note("EsEngineListener.release()");
    }
}

class Program
{
    //-------------------------------------------------------------------------
    static void Main(string[] args)
    {
        Console.Title = "EsTest";

        EsEngineSettings settings;
        settings.NodeType = 2;
        settings.NodeTypeString = "EsTest";
        settings.ListenIp = "127.0.0.1";
        settings.ListenPort = 5882;
        settings.RootEntityType = "EtNode";
        settings.EnableCoSupersocket = false;
        settings.EnableCoUCenterSDK = false;
        settings.Log4NetConfigPath = "../../../Media/EsTest/EsTest.log4net.config";

        EsEngine e = new EsEngine(ref settings, new EsEngineListener());
        e.run();
    }
}
