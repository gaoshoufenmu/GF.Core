using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Orleans;

namespace Es
{
    // 无状态服务
    public interface IUCenterService : IGrainWithIntegerKey
    {
        //---------------------------------------------------------------------
        Task<ClientRegisterResponse> clientRegister(ClientRegisterRequest register_request);

        //---------------------------------------------------------------------
        Task<ClientLoginResponse> clientLogin(ClientLoginRequest login_request);

        //---------------------------------------------------------------------
        Task<AppLoginResponse> appLogin(AppLoginRequest app_login_request);

        //---------------------------------------------------------------------
        Task<AppVerifyAccountResponse> appVerifyAccount(AppVerifyAccountRequest login_verify_request);

        //---------------------------------------------------------------------
        Task<AppWriteDataResponse> appWriteData(AppWriteDataRequest write_appdata_request);

        //---------------------------------------------------------------------
        Task<AppReadDataResponse> appReadData(AppReadDataRequest read_appdata_request);
    }
}
