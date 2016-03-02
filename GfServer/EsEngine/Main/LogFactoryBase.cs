using System;
using System.Collections.Generic;
using System.IO;

namespace Es
{
    public abstract class LogFactoryBase : ILogFactory
    {
        //---------------------------------------------------------------------
        protected string ConfigDir { get; private set; }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets the config file file path.
        /// </summary>
        protected string ConfigFile { get; private set; }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets a value indicating whether the server instance is running in isolation mode and the multiple server instances share the same logging configuration.
        /// </summary>
        protected bool IsSharedConfig { get; private set; }

        //---------------------------------------------------------------------
        /// <summary>
        /// Initializes a new instance of the <see cref="LogFactoryBase"/> class.
        /// </summary>
        /// <param name="configFile">The config file.</param>
        protected LogFactoryBase(string configFile)
        {
            ConfigDir = configFile;

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigDir);

            if (File.Exists(filePath))
            {
                ConfigFile = filePath;
                return;
            }

            filePath = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ConfigDir, "Config"), configFile);

            if (File.Exists(filePath))
            {
                ConfigFile = filePath;
                return;
            }

            ConfigFile = configFile;

            if (Path.DirectorySeparatorChar != '\\')
            {
                configFile = Path.GetFileNameWithoutExtension(configFile) + ".unix" + Path.GetExtension(configFile);
            }
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets the log by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public abstract ILog GetLog(string name);

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets the log from the specific repository.
        /// </summary>
        /// <param name="repositoryName">Name of the repository.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public abstract ILog GetLog(string repositoryName, string name);
    }
}
