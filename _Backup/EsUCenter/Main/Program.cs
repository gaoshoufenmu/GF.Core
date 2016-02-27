using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Orleans.Runtime;
using Orleans.Runtime.Host;
using Eb;
using Es;

class Program
{
    //-------------------------------------------------------------------------
    static void Main(string[] args)
    {
        Console.Title = "EsUCenter";

        var silo_host = new WindowsServerHost();

        int exit_code;
        try
        {
            if (!silo_host.ParseArguments(args))
            {
                silo_host.PrintUsage();
                exit_code = -1;
            }
            else
            {
                silo_host.Init();
                exit_code = silo_host.Run();
            }
        }
        catch (Exception ex)
        {
            EbLog.Error(string.Format("halting due to error - {0}", ex.ToString()));
            exit_code = 1;
        }
        finally
        {
            silo_host.Dispose();
        }

        Environment.Exit(exit_code);
    }
}
