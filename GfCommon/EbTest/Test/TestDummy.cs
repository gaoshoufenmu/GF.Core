using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Eb;

class TestDummy : Test
{
    //-------------------------------------------------------------------------
    public override void init()
    {
        EbLog.Note("TestDummy.init()");

        ClientLoginRequest login_request = new ClientLoginRequest();
        login_request.acc = "test1010";
        login_request.pwd = "123456";

        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://www.cragon.cn/");

            HttpContent httpContent = new StringContent(EbTool.jsonSerialize(login_request));
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            string s = httpContent.ReadAsStringAsync().Result;
            Console.WriteLine(s);
            var result = client.PostAsync("ucenter/api/account/login", httpContent).Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }
    }

    //-------------------------------------------------------------------------
    public override void release()
    {
        EbLog.Note("TestDummy.release()");
    }

    //-------------------------------------------------------------------------
    public override void update()
    {
    }
}
