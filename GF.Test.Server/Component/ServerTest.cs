using System;
using System.Collections.Generic;
using System.Text;
using Eb;
using Es;

public class DefTest : ComponentDef
{
    //---------------------------------------------------------------------
    public override void defAllProp(Dictionary<string, string> map_param)
    {
    }
}

public class ServerTest<T> : Component<T> where T : DefTest, new()
{
    //-------------------------------------------------------------------------
    //EsUCenterSDK4Server UCenterSDK4Server { get; set; }

    //-------------------------------------------------------------------------
    public override void init()
    {
        EbLog.Note("ServerTest.init()");

        //UCenterSDK4Server = new EsUCenterSDK4Server(EntityMgr, Entity,
        //    "../../../Media/EsTest/EsUCenterSDK4Server.dll.config", null);
    }

    //-------------------------------------------------------------------------
    public override void release()
    {
        EbLog.Note("ServerTest.release()");
    }

    //-------------------------------------------------------------------------
    public override void update(float elapsed_tm)
    {
    }

    //-------------------------------------------------------------------------
    public override void handleEvent(object sender, EntityEvent e)
    {
    }
}
