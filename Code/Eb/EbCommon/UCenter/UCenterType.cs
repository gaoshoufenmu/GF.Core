using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//-------------------------------------------------------------------------
public enum UCenterResult : short
{
    Success = 0,// 通用，成功
    Failed = 10,// 失败
    Timeout = 20,// 超时
    RegisterAccountExist = 100,// 注册，用户名重复
    LoginAccountNotExist = 200,// 登陆，帐号不存在
    LoginPwdError,// 登陆，密码错误
    LoginVerifyAccountNotExit = 300,// App验证登录，帐号不存在
    LoginVerifyInvalidApp,// 非法App
    LoginVerifyReadAppDataFailed,// 读取AppData失败
    LoginVerifyWriteAppDataFailed,// 写入AppData失败
}

//-----------------------------------------------------------------------------
// 性别
public enum SexType : byte
{
    None = 0,// 无效
    Male,// 男
    Female,// 女
    Other,// 其他
}

//-------------------------------------------------------------------------
// 注册帐号信息
[Serializable]
public class ClientRegisterRequest
{
    public string acc;
    public string pwd;
    public string super_pwd;
    public string phone_num;
    public string name;
    public string identity_num;
    public SexType sex_type;
}

//-------------------------------------------------------------------------
[Serializable]
public class ClientRegisterResponse
{
    public UCenterResult result;
    public string token;
    public ulong acc_id;
    public string acc_name;
}

//-------------------------------------------------------------------------
[Serializable]
public class ClientLoginRequest
{
    public string acc;
    public string pwd;
    public string project_name;
    public string protocol_version;
    public string channel_name;
    public Dictionary<string, string> map_param;
}

//-------------------------------------------------------------------------
[Serializable]
public class ClientLoginResponse
{
    public UCenterResult result;
    public string token;
    public ulong acc_id;
    public string acc_name;
    public SexType sex;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppLoginRequest
{
    public string app_id;
    public string data;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppLoginResponse
{
    public UCenterResult result;
    public string app_id;
    public string app_token;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppVerifyAccountRequest
{
    public string app_id;
    public string app_token;
    public ulong acc_id;
    public string acc_name;
    public string token;
    public bool get_appdata;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppVerifyAccountResponse
{
    public UCenterResult result;
    public string app_id;
    public ulong acc_id;
    public string acc_name;
    public string token;
    public DateTime last_login_dt;
    public DateTime now_dt;
    public AppData app_data;
}

//-------------------------------------------------------------------------
[Serializable]
public class VerifyAccountData
{
    public UCenterResult result;
    public ulong acc_id;
    public string token;
    public DateTime last_login_dt;
    public DateTime now_dt;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppData
{
    public ulong acc_id;
    public string appdata1;
    public string appdata2;
    public string appdata3;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppWriteDataRequest
{
    public string app_id;
    public string app_token;
    public AppData app_data;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppWriteDataResponse
{
    public UCenterResult result;
    public string app_id;
    public AppData app_data;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppReadDataRequest
{
    public string app_id;
    public string app_token;
    public ulong acc_id;
}

//-------------------------------------------------------------------------
[Serializable]
public class AppReadDataResponse
{
    public UCenterResult result;
    public string app_id;
    public ulong acc_id;
    public AppData app_data;
}
