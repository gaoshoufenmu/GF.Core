using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using Orleans;
using Orleans.Concurrency;
using Orleans.Runtime;
using Eb;

namespace Es
{
    [Reentrant]
    [StatelessWorker]
    public class GrainUCenterService : Grain, IUCenterService
    {
        //---------------------------------------------------------------------
        public Logger Logger { get { return GetLogger(); } }
        DbClientMySQL ClientMySQL { get; set; }

        //---------------------------------------------------------------------
        public override Task OnActivateAsync()
        {
            ClientMySQL = new DbClientMySQL();

            return base.OnActivateAsync();
        }

        //---------------------------------------------------------------------
        public override Task OnDeactivateAsync()
        {
            ClientMySQL = null;

            return base.OnDeactivateAsync();
        }

        //---------------------------------------------------------------------
        async Task<ClientRegisterResponse> IUCenterService.clientRegister(ClientRegisterRequest register_request)
        {
            string info = string.Format("客户端请求注册\nAcc={0}  Pwd={1}", register_request.acc, register_request.pwd);
            Logger.Info(info);

            ClientRegisterResponse result = await ClientMySQL.register(register_request);

            return result;
        }

        //---------------------------------------------------------------------
        async Task<ClientLoginResponse> IUCenterService.clientLogin(ClientLoginRequest login_request)
        {
            string info = string.Format("客户端请求登录\nAcc={0}  Pwd={1}", login_request.acc, login_request.pwd);
            Logger.Info(info);

            ClientLoginResponse result = await ClientMySQL.login(login_request.acc, login_request.pwd);

            return result;
        }

        //---------------------------------------------------------------------
        Task<AppLoginResponse> IUCenterService.appLogin(AppLoginRequest app_login_request)
        {
            string info = string.Format("App请求登录\nAppId={0}", app_login_request.app_id);
            Logger.Info(info);

            AppLoginResponse result = new AppLoginResponse();

            return Task.FromResult(result);
        }

        //---------------------------------------------------------------------
        async Task<AppVerifyAccountResponse> IUCenterService.appVerifyAccount(AppVerifyAccountRequest login_verify_request)
        {
            AppVerifyAccountResponse result = new AppVerifyAccountResponse();
            result.result = UCenterResult.Failed;
            result.app_id = login_verify_request.app_id;
            result.acc_id = login_verify_request.acc_id;
            result.acc_name = login_verify_request.acc_name;

            // 验证App合法性
            //bool is_valid_app = await ClientMySQL.isValidApp(login_verify_request.app_id, login_verify_request.app_secret);
            //if (!is_valid_app)
            //{
            //    result.result = UCenterResult.LoginVerifyInvalidApp;
            //    return result;
            //}

            string info = string.Format("App请求验证帐号\nAppId={0} AccId={1} AccName={2}",
                login_verify_request.app_id, login_verify_request.acc_id, login_verify_request.acc_name);
            Logger.Info(info);

            // 获取用户Token信息
            VerifyAccountData acc_verify_data = await ClientMySQL.getAccountVerifyData(login_verify_request.acc_id);
            if (acc_verify_data.result != UCenterResult.Success)
            {
                result.result = acc_verify_data.result;
                return result;
            }

            result.token = acc_verify_data.token;
            result.last_login_dt = acc_verify_data.last_login_dt;
            result.now_dt = DateTime.Now;

            // 获取AppData
            if (login_verify_request.get_appdata)
            {
                AppReadDataRequest read_appdata_request = new AppReadDataRequest();
                read_appdata_request.app_id = login_verify_request.app_id;
                read_appdata_request.acc_id = login_verify_request.acc_id;

                var grain_ucenterservice = GrainFactory.GetGrain<IUCenterService>(0);
                AppReadDataResponse read_appdata_response = await grain_ucenterservice.appReadData(read_appdata_request);
                if (read_appdata_response.result != UCenterResult.Success)
                {
                    result.result = acc_verify_data.result;
                    return result;
                }

                result.app_data = read_appdata_response.app_data;
            }

            result.result = UCenterResult.Success;
            return result;
        }

        //---------------------------------------------------------------------
        async Task<AppWriteDataResponse> IUCenterService.appWriteData(AppWriteDataRequest write_appdata_request)
        {
            string info = string.Format("App请求写入AppData\nAppId={0}",
                write_appdata_request.app_id);
            Logger.Info(info);

            AppWriteDataResponse result = await ClientMySQL.appWriteData(write_appdata_request);

            return result;
        }

        //---------------------------------------------------------------------
        async Task<AppReadDataResponse> IUCenterService.appReadData(AppReadDataRequest read_appdata_request)
        {
            string info = string.Format("App请求读取AppData\nAppId={0}",
                read_appdata_request.app_id);
            Logger.Info(info);

            AppReadDataResponse result = await ClientMySQL.appReadData(read_appdata_request);

            return result;
        }
    }
}
