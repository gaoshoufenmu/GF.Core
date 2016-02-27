using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using Eb;
using Es;

public class MySQLRequest
{
    public MySqlConnection con;
    public MySqlCommand cmd;
    public string acc_name;
}

public class DbClientMySQL
{
    //-------------------------------------------------------------------------
    public string ConStr { get; private set; }

    //-------------------------------------------------------------------------
    public DbClientMySQL()
    {
        ConStr = ConfigurationManager.AppSettings["MysqlConfigStr"];
    }

    //-------------------------------------------------------------------------
    public async Task<ClientRegisterResponse> register(ClientRegisterRequest register_account_data)
    {
        string name = string.IsNullOrEmpty(register_account_data.name) ? "" : register_account_data.name;
        name = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(name));

        string identity_num = string.IsNullOrEmpty(register_account_data.identity_num) ? "" : register_account_data.identity_num;
        string phone_num = string.IsNullOrEmpty(register_account_data.phone_num) ? "" : register_account_data.phone_num;

        string sql_str = string.Format("INSERT INTO Account SET AccountName='{0}', Password='{1}', Name='{2}', IdentityNum='{3}', PhoneNum='{4}', Sex='{5}';",
            register_account_data.acc,
            register_account_data.pwd,
            name,
            identity_num,
            phone_num,
            (int)register_account_data.sex_type);

        MySqlConnection con = new MySqlConnection(ConStr);
        con.Open();

        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql_str;

        MySQLRequest request = new MySQLRequest();
        request.con = con;
        request.cmd = cmd;

        ClientRegisterResponse result = new ClientRegisterResponse();
        result.result = UCenterResult.Failed;
        result.acc_name = request.acc_name;

        try
        {
            await Task<int>.Factory.FromAsync(cmd.BeginExecuteNonQuery(), cmd.EndExecuteNonQuery);

            sql_str = string.Format("SELECT AccountId From Account WHERE binary AccountName='{0}';", register_account_data.acc);
            cmd.CommandText = sql_str;
            MySqlDataReader data = await Task<MySqlDataReader>.Factory.FromAsync(cmd.BeginExecuteReader(), cmd.EndExecuteReader);

            var dt = new DataTable();
            dt.Load(data);
            data.Dispose();

            DataRow[] rows = dt.Select();
            if (rows.Length == 1)
            {
                result.result = UCenterResult.Success;
                result.acc_id = (ulong)((long)rows[0]["AccountId"]);

                EbLog.Note("AccountId=" + result.acc_id);
            }
        }
        catch (MySqlException ex)
        {
            EbLog.Note(ex.ToString());

            switch (ex.Number)
            {
                case 1062:
                    {
                        result.result = UCenterResult.RegisterAccountExist;
                        EbLog.Note("用户名重复, AccountName=" + register_account_data.acc);
                    }
                    break;
                default:
                    break;
            }
        }
        finally
        {
            request.con.Close();
            request.con.Dispose();
            request.cmd.Dispose();
        }

        return result;
    }

    //-------------------------------------------------------------------------
    public async Task<ClientLoginResponse> login(string account_name, string password)
    {
        string sql_str = string.Format("SELECT * FROM Account WHERE binary AccountName='{0}' AND binary Password='{1}' ;",
            account_name, password);

        MySqlConnection con = new MySqlConnection(ConStr);
        con.Open();

        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql_str;

        ClientLoginResponse result = new ClientLoginResponse();
        result.result = UCenterResult.Failed;
        result.acc_name = account_name;

        try
        {
            MySqlDataReader data = await Task<MySqlDataReader>.Factory.FromAsync(cmd.BeginExecuteReader(), cmd.EndExecuteReader);
            var dt = new DataTable();
            dt.Load(data);
            data.Dispose();

            DataRow[] rows = dt.Select();
            if (rows.Length == 1)
            {
                result.result = UCenterResult.Success;
                result.acc_id = (ulong)((long)rows[0]["AccountId"]);
                result.sex = (SexType)(int)rows[0]["Sex"];
            }
            else
            {
                result.result = UCenterResult.LoginAccountNotExist;
                result.acc_id = 0;
            }
        }
        catch (System.Exception ex)
        {
            EbLog.Error("DbClientMySQL.login() Exception: " + ex);
            result.result = UCenterResult.Failed;
            result.acc_id = 0;
            goto End;
        }

        if (result.result == UCenterResult.Success)
        {
            string token = Guid.NewGuid().ToString();
            sql_str = string.Format("UPDATE Account set Token='{0}', LastLoginDt='{1}' WHERE AccountId={2};",
                token, DateTime.Now.ToString(), result.acc_id);
            cmd.CommandText = sql_str;

            try
            {
                await Task<int>.Factory.FromAsync(cmd.BeginExecuteNonQuery(), cmd.EndExecuteNonQuery);
                result.token = token;
            }
            catch (Exception ex)
            {
                EbLog.Error("DbClientMySQL.login() Exception: " + ex);
                result.result = UCenterResult.Failed;
                result.token = "";
                goto End;
            }
        }

        End:
        con.Close();
        con.Dispose();
        cmd.Dispose();

        return result;
    }

    //-------------------------------------------------------------------------
    public async Task<bool> isValidApp(string app_id, string app_secret)
    {
        string sql_str = string.Format("SELECT * FROM AppMgr WHERE binary AppId='{0}' AND binary AppSecret='{1}' ;",
            app_id, app_secret);

        MySqlConnection con = new MySqlConnection(ConStr);
        con.Open();

        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql_str;

        try
        {
            MySqlDataReader data = await Task<MySqlDataReader>.Factory.FromAsync(cmd.BeginExecuteReader(), cmd.EndExecuteReader);
            var dt = new DataTable();
            dt.Load(data);
            data.Dispose();

            DataRow[] rows = dt.Select();
            if (rows.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (System.Exception ex)
        {
            EbLog.Error("DbClientMySQL.isValidApp() Exception: " + ex);
        }

        con.Close();
        con.Dispose();
        cmd.Dispose();

        return false;
    }

    //-------------------------------------------------------------------------
    public async Task<VerifyAccountData> getAccountVerifyData(ulong acc_id)
    {
        string sql_str = string.Format("SELECT * FROM Account WHERE binary AccountId='{0}';", acc_id);

        MySqlConnection con = new MySqlConnection(ConStr);
        con.Open();

        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql_str;

        VerifyAccountData result = new VerifyAccountData();
        result.result = UCenterResult.Failed;
        result.acc_id = acc_id;

        try
        {
            MySqlDataReader data = await Task<MySqlDataReader>.Factory.FromAsync(cmd.BeginExecuteReader(), cmd.EndExecuteReader);
            var dt = new DataTable();
            dt.Load(data);
            data.Dispose();

            DataRow[] rows = dt.Select();
            if (rows.Length == 1)
            {
                result.result = UCenterResult.Success;
                result.token = (string)rows[0]["Token"];
                result.last_login_dt = (DateTime)rows[0]["LastLoginDt"];
            }
            else
            {
                result.result = UCenterResult.LoginAccountNotExist;
            }
        }
        catch (System.Exception ex)
        {
            EbLog.Error("DbClientMySQL.login() getAccountVerifyData: " + ex);
            goto End;
        }

        End:
        con.Close();
        con.Dispose();
        cmd.Dispose();

        return result;
    }

    //---------------------------------------------------------------------
    public async Task<AppWriteDataResponse> appWriteData(AppWriteDataRequest write_appdata_request)
    {
        AppWriteDataResponse result = new AppWriteDataResponse();
        result.result = UCenterResult.LoginVerifyWriteAppDataFailed;
        result.app_id = write_appdata_request.app_id;

        //bool is_valid_app = await isValidApp(write_appdata_request.app_id, write_appdata_request.app_secret);
        //if (!is_valid_app) return result;

        if (write_appdata_request.app_data.appdata1 == null) write_appdata_request.app_data.appdata1 = "";
        if (write_appdata_request.app_data.appdata2 == null) write_appdata_request.app_data.appdata2 = "";
        if (write_appdata_request.app_data.appdata3 == null) write_appdata_request.app_data.appdata3 = "";

        string sql_str = string.Format("INSERT INTO app_{0} SET AccountId='{1}', AppData1='{2}', AppData2='{3}', AppData3='{4}';",
            write_appdata_request.app_id,
            write_appdata_request.app_data.acc_id,
            write_appdata_request.app_data.appdata1,
            write_appdata_request.app_data.appdata2,
            write_appdata_request.app_data.appdata3);

        MySqlConnection con = new MySqlConnection(ConStr);
        con.Open();

        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql_str;

        MySQLRequest request = new MySQLRequest();
        request.con = con;
        request.cmd = cmd;

        try
        {
            await Task<int>.Factory.FromAsync(cmd.BeginExecuteNonQuery(), cmd.EndExecuteNonQuery);
            result.result = UCenterResult.Success;
            result.app_data = write_appdata_request.app_data;
        }
        catch (MySqlException ex)
        {
            EbLog.Note(ex.ToString());

            result.result = UCenterResult.LoginVerifyWriteAppDataFailed;
        }
        finally
        {
            request.con.Close();
            request.con.Dispose();
            request.cmd.Dispose();
        }

        return result;
    }

    //---------------------------------------------------------------------
    public async Task<AppReadDataResponse> appReadData(AppReadDataRequest read_appdata_request)
    {
        AppReadDataResponse result = new AppReadDataResponse();
        result.result = UCenterResult.LoginVerifyReadAppDataFailed;
        result.app_id = read_appdata_request.app_id;
        result.acc_id = read_appdata_request.acc_id;

        //bool is_valid_app = await isValidApp(read_appdata_request.app_id, read_appdata_request.app_secret);
        //if (!is_valid_app)
        //{
        //    return result;
        //}

        string sql_str = string.Format("SELECT * FROM app_{0} WHERE binary AccountId='{1}';",
            read_appdata_request.app_id, read_appdata_request.acc_id);

        MySqlConnection con = new MySqlConnection(ConStr);
        con.Open();

        MySqlCommand cmd = con.CreateCommand();
        cmd.CommandText = sql_str;

        try
        {
            MySqlDataReader data = await Task<MySqlDataReader>.Factory.FromAsync(cmd.BeginExecuteReader(), cmd.EndExecuteReader);
            var dt = new DataTable();
            dt.Load(data);
            data.Dispose();

            DataRow[] rows = dt.Select();
            if (rows.Length == 1)
            {
                result.result = UCenterResult.Success;
                result.app_data = new AppData();
                result.app_data.acc_id = result.acc_id;
                result.app_data.appdata1 = (string)rows[0]["AppData1"];
                result.app_data.appdata2 = (string)rows[0]["AppData2"];
                result.app_data.appdata3 = (string)rows[0]["AppData3"];
            }
        }
        catch (System.Exception ex)
        {
            EbLog.Error(ex.ToString());
            goto End;
        }

        End:
        con.Close();
        con.Dispose();
        cmd.Dispose();

        return result;
    }
}
