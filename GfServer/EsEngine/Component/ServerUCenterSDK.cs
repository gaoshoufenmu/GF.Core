using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Eb;

namespace Es
{
    public class ServerUCenterSDK<TDef> : Component<TDef> where TDef : DefUCenterSDK, new()
    {
        //---------------------------------------------------------------------
        public string UCenterDomain { get; set; }

        //---------------------------------------------------------------------
        public override void init()
        {
            EbLog.Note("ServerUCenterSDK.init()");
        }

        //---------------------------------------------------------------------
        public override void release()
        {
            EbLog.Note("ServerUCenterSDK.release()");
        }

        //---------------------------------------------------------------------
        public override void update(float elapsed_tm)
        {
        }

        //---------------------------------------------------------------------
        public override void handleEvent(object sender, EntityEvent e)
        {
        }

        //---------------------------------------------------------------------
        public async Task<AppLoginResponse> appLogin(AppLoginRequest app_login_request)
        {
            AppLoginResponse result = new AppLoginResponse();

            return result;
        }

        //---------------------------------------------------------------------
        public async Task<AppVerifyAccountResponse> appVerifyAccount(AppVerifyAccountRequest app_verifyaccount_request)
        {
            AppVerifyAccountResponse app_verifyaccount_response = null;

            // 去UCenter验证用户信息
            using (var client = new HttpClient())
            {
                string result_data = null;
                string http_url = string.Format("https://{0}/", UCenterDomain);
                client.BaseAddress = new Uri(http_url);

                using (HttpContent http_content = new StringContent(EbTool.jsonSerialize(app_verifyaccount_request)))
                {
                    http_content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    using (HttpResponseMessage http_result = await client.PostAsync("ucenter/api/app/verifyaccount", http_content))
                    {
                        result_data = await http_result.Content.ReadAsStringAsync();
                    }
                }

                if (!string.IsNullOrEmpty(result_data))
                {
                    string info = string.Format("去UCenter请求验证用户，Result:\n{0}", result_data);
                    EbLog.Note(info);
                }

                if (!string.IsNullOrEmpty(result_data))
                {
                    app_verifyaccount_response = EbTool.jsonDeserialize<AppVerifyAccountResponse>(result_data);
                }
            }

            if (app_verifyaccount_response == null)
            {
                app_verifyaccount_response = new AppVerifyAccountResponse();
                app_verifyaccount_response.result = UCenterResult.Failed;
            }

            return app_verifyaccount_response;
        }

        //---------------------------------------------------------------------
        public async Task<AppWriteDataResponse> appWriteData(AppWriteDataRequest write_appdata_request)
        {
            AppWriteDataResponse write_appdata_response = null;

            // 向UCenter写入AppData
            using (var client = new HttpClient())
            {
                string result_data = null;
                string http_url = string.Format("https://{0}/", UCenterDomain);
                client.BaseAddress = new Uri(http_url);
                using (HttpContent http_content = new StringContent(EbTool.jsonSerialize(write_appdata_request)))
                {
                    http_content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    using (HttpResponseMessage http_result = await client.PostAsync("ucenter/api/app/writedata", http_content))
                    {
                        result_data = await http_result.Content.ReadAsStringAsync();
                    }
                }

                if (!string.IsNullOrEmpty(result_data))
                {
                    string info = string.Format("去UCenter请求验证用户，Result:\n{0}", result_data);
                    EbLog.Note(info);
                }

                if (!string.IsNullOrEmpty(result_data))
                {
                    write_appdata_response = EbTool.jsonDeserialize<AppWriteDataResponse>(result_data);
                }
            }

            if (write_appdata_response == null)
            {
                write_appdata_response = new AppWriteDataResponse();
                write_appdata_response.result = UCenterResult.Failed;
            }

            return write_appdata_response;
        }

        //---------------------------------------------------------------------
        public async Task<AppReadDataResponse> appReadData(AppReadDataRequest read_appdata_request)
        {
            AppReadDataResponse read_appdata_response = null;

            // 从UCenter读取AppData
            using (var client = new HttpClient())
            {
                string result_data = null;
                string http_url = string.Format("https://{0}/", UCenterDomain);
                client.BaseAddress = new Uri(http_url);
                using (HttpContent http_content = new StringContent(EbTool.jsonSerialize(read_appdata_request)))
                {
                    http_content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    using (HttpResponseMessage http_result = await client.PostAsync("ucenter/api/app/readdata", http_content))
                    {
                        result_data = await http_result.Content.ReadAsStringAsync();
                    }
                }

                if (!string.IsNullOrEmpty(result_data))
                {
                    string info = string.Format("去UCenter请求验证用户，Result:\n{0}", result_data);
                    EbLog.Note(info);
                }

                if (!string.IsNullOrEmpty(result_data))
                {
                    read_appdata_response = EbTool.jsonDeserialize<AppReadDataResponse>(result_data);
                }
            }

            if (read_appdata_response == null)
            {
                read_appdata_response = new AppReadDataResponse();
                read_appdata_response.result = UCenterResult.Failed;
            }

            return read_appdata_response;
        }
    }
}
