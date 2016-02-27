using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Eb;

public class ClientSampleUCenter<TDef> : Component<TDef> where TDef : DefSampleUCenter, new()
{
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    public override void init()
    {
        EbLog.Note("ClientSampleUCenter.init()");

        EntityMgr.getDefaultEventPublisher().addHandler(Entity);

        Ec.EcEngine.Instance.CoUCenterSDK.UCenterDomain = "www.cragon.cn";

        ClientLoginRequest login_request = new ClientLoginRequest();
        login_request.acc = "test1010";
        login_request.pwd = "123456";
        Ec.EcEngine.Instance.CoUCenterSDK.login(login_request, _onUCenterLogin);
    }

    //-------------------------------------------------------------------------
    public override void release()
    {
        EbLog.Note("ClientSampleUCenter.release()");
    }

    //-------------------------------------------------------------------------
    public override void update(float elapsed_tm)
    {
    }

    //-------------------------------------------------------------------------
    public override void handleEvent(object sender, EntityEvent e)
    {
    }

    //-------------------------------------------------------------------------
    void _onUCenterLogin(ClientLoginResponse login_response)
    {
        EbLog.Note("ClientSampleUCenter._onUCenterLogin() UCenterResult=" + login_response.result);
    }
}
