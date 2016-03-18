using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.Common;
using SuperSocket.ProtoBase;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Logging;
using SuperSocket.SocketBase.Protocol;
using SuperSocket.SocketEngine;

namespace GF.Server
{
    public class SuperSocketLog : SuperSocket.SocketBase.Logging.ILog
    {
        //---------------------------------------------------------------------
        ILog m_Log;

        //---------------------------------------------------------------------
        public SuperSocketLog(ILog log)
        {
            m_Log = log;
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsDebugEnabled
        {
            get { if (m_Log == null) return false; return m_Log.IsDebugEnabled; }
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets a value indicating whether this instance is error enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is error enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorEnabled
        {
            get { if (m_Log == null) return false; return m_Log.IsErrorEnabled; }
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsFatalEnabled
        {
            get { if (m_Log == null) return false; return m_Log.IsFatalEnabled; }
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets a value indicating whether this instance is info enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is info enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsInfoEnabled
        {
            get { if (m_Log == null) return false; return m_Log.IsInfoEnabled; }
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets a value indicating whether this instance is warn enabled.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsWarnEnabled
        {
            get { if (m_Log == null) return false; return m_Log.IsWarnEnabled; }
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(object message)
        {
            if (null != m_Log)
                m_Log.Debug(message);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Debug(object message, Exception exception)
        {
            if (null != m_Log)
                m_Log.Debug(message, exception);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void DebugFormat(string format, object arg0)
        {
            if (null != m_Log)
                m_Log.DebugFormat(format, arg0);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void DebugFormat(string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.DebugFormat(format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.DebugFormat(provider, format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void DebugFormat(string format, object arg0, object arg1)
        {
            if (null != m_Log)
                m_Log.DebugFormat(format, arg0, arg1);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the debug message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void DebugFormat(string format, object arg0, object arg1, object arg2)
        {
            if (null != m_Log)
                m_Log.DebugFormat(format, arg0, arg1, arg2);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(object message)
        {
            if (null != m_Log)
                m_Log.Error(message);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Error(object message, Exception exception)
        {
            if (null != m_Log)
                m_Log.Error(message, exception);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void ErrorFormat(string format, object arg0)
        {
            if (null != m_Log)
                m_Log.ErrorFormat(format, arg0);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void ErrorFormat(string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.ErrorFormat(format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.ErrorFormat(provider, format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void ErrorFormat(string format, object arg0, object arg1)
        {
            if (null != m_Log)
                m_Log.ErrorFormat(format, arg0, arg1);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void ErrorFormat(string format, object arg0, object arg1, object arg2)
        {
            if (null != m_Log)
                m_Log.ErrorFormat(format, arg0, arg1, arg2);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(object message)
        {
            if (null != m_Log)
                m_Log.Fatal(message);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Fatal(object message, Exception exception)
        {
            if (null != m_Log)
                m_Log.Fatal(message, exception);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void FatalFormat(string format, object arg0)
        {
            if (null != m_Log)
                m_Log.FatalFormat(format, arg0);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void FatalFormat(string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.FatalFormat(format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.FatalFormat(provider, format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void FatalFormat(string format, object arg0, object arg1)
        {
            if (null != m_Log)
                m_Log.FatalFormat(format, arg0, arg1);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the fatal error message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void FatalFormat(string format, object arg0, object arg1, object arg2)
        {
            if (null != m_Log)
                m_Log.FatalFormat(format, arg0, arg1, arg2);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(object message)
        {
            if (null != m_Log)
                m_Log.Info(message);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Info(object message, Exception exception)
        {
            if (null != m_Log)
                m_Log.Info(message, exception);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void InfoFormat(string format, object arg0)
        {
            if (null != m_Log)
                m_Log.InfoFormat(format, arg0);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void InfoFormat(string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.InfoFormat(format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.InfoFormat(provider, format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void InfoFormat(string format, object arg0, object arg1)
        {
            if (null != m_Log)
                m_Log.InfoFormat(format, arg0, arg1);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the info message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void InfoFormat(string format, object arg0, object arg1, object arg2)
        {
            if (null != m_Log)
                m_Log.InfoFormat(format, arg0, arg1, arg2);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Warn(object message)
        {
            if (null != m_Log)
                m_Log.Warn(message);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public void Warn(object message, Exception exception)
        {
            if (null != m_Log)
                m_Log.Warn(message, exception);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        public void WarnFormat(string format, object arg0)
        {
            if (null != m_Log)
                m_Log.WarnFormat(format, arg0);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WarnFormat(string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.WarnFormat(format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="format">The format.</param>
        /// <param name="args">The args.</param>
        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (null != m_Log)
                m_Log.WarnFormat(provider, format, args);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        public void WarnFormat(string format, object arg0, object arg1)
        {
            if (null != m_Log)
                m_Log.WarnFormat(format, arg0, arg1);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the warning message.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="arg0">The arg0.</param>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public void WarnFormat(string format, object arg0, object arg1, object arg2)
        {
            if (null != m_Log)
                m_Log.WarnFormat(format, arg0, arg1, arg2);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Logs the specified logging data.
        /// </summary>
        /// <param name="loggingData">The logging data.</param>
        /// <exception cref="System.NotSupportedException"></exception>
        public void Log(LoggingData loggingData)
        {
            throw new NotSupportedException();
        }
    }

    public class SuperSocketLogFactory : SuperSocket.SocketBase.Logging.ILogFactory
    {
        //---------------------------------------------------------------------
        /// <summary>
        /// Gets the log by name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public SuperSocket.SocketBase.Logging.ILog GetLog(string name)
        {
            //return new SuperSocketLog(EbLogFactory.GetLog(name));
            return new SuperSocketLog(null);
        }

        //---------------------------------------------------------------------
        /// <summary>
        /// Gets the log from the specific repository.
        /// </summary>
        /// <param name="repositoryName">Name of the repository.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public SuperSocket.SocketBase.Logging.ILog GetLog(string repositoryName, string name)
        {
            //return new SuperSocketLog(EbLogFactory.GetLog(repositoryName, name));
            return new SuperSocketLog(null);
        }
    }
}
