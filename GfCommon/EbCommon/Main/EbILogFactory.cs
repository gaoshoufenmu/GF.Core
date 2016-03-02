using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// LogFactory Interface
/// </summary>
public interface ILogFactory
{
    /// <summary>
    /// Gets the log by name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    ILog GetLog(string name);


    /// <summary>
    /// Gets the log from the specific repository.
    /// </summary>
    /// <param name="repositoryName">Name of the repository.</param>
    /// <param name="name">The name.</param>
    /// <returns></returns>
    ILog GetLog(string repositoryName, string name);
}

public static class EbLogFactory
{
    public static void SetLogFactory(ILogFactory log_factory)
    {
        AppDomain.CurrentDomain.SetData("ILogFactory",log_factory);
    }

    public static ILog GetLog(string repositoryName, string name)
    {
       if (AppDomain.CurrentDomain.GetData("ILogFactory") == null) return null;
       ILogFactory log_factory = AppDomain.CurrentDomain.GetData("ILogFactory") as ILogFactory;
       return log_factory.GetLog(repositoryName, name);
    }
    public static ILog GetLog(string name)
    {
        if (AppDomain.CurrentDomain.GetData("ILogFactory") == null) return null;
        ILogFactory log_factory = AppDomain.CurrentDomain.GetData("ILogFactory") as ILogFactory;
        return log_factory.GetLog(name);
    }

}
