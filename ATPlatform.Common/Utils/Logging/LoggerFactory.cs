// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.Logging.LoggerFactory
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using log4net;
using log4net.Appender;
using log4net.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATPlatform.Common.Utils.Logging
{
  public class LoggerFactory
  {
    public static ILogger GetLogger(string name) => (ILogger) new LoggerFactory.Log4NetLogger(name);

    public static ILogger GetLogger(Type type) => (ILogger) new LoggerFactory.Log4NetLogger(type);

    private class Log4NetLogger : ILogger
    {
      private const string DefaultName = "Default";
      private static readonly string separator = "_";
      private static readonly string dateTimeFormat = "yyyyMMdd" + LoggerFactory.Log4NetLogger.separator + "HHmmss.fff";
      private readonly string _loggerName;
      private readonly ILog _logger;

      public string Name => this._loggerName;

      public bool IsFatalEnabled => this._logger.IsWarnEnabled;

      public bool IsWarnEnabled => this._logger.IsWarnEnabled;

      public bool IsInfoEnabled => this._logger.IsInfoEnabled;

      public void Debug(object message) => this._logger.Debug(message);

      public void Debug(object message, Exception exception) => this._logger.Debug(message, exception);

      public void DebugFormat(string format, params object[] args) => this._logger.DebugFormat(format, args);

      public void DebugFormat(string format, object arg0) => this._logger.DebugFormat(format, arg0);

      public void DebugFormat(string format, object arg0, object arg1) => this._logger.DebugFormat(format, arg0, arg1);

      public void DebugFormat(string format, object arg0, object arg1, object arg2) => this._logger.DebugFormat(format, arg0, arg1, arg2);

      public void DebugFormat(IFormatProvider provider, string format, params object[] args) => this._logger.DebugFormat(provider, format, args);

      public void Info(object message) => this._logger.Info(message);

      public void Info(object message, Exception exception) => this._logger.Info(message, exception);

      public void InfoFormat(string format, params object[] args) => this._logger.InfoFormat(format, args);

      public void InfoFormat(string format, object arg0) => this._logger.InfoFormat(format, arg0);

      public void InfoFormat(string format, object arg0, object arg1) => this._logger.InfoFormat(format, arg0, arg1);

      public void InfoFormat(string format, object arg0, object arg1, object arg2) => this._logger.InfoFormat(format, arg0, arg1, arg2);

      public void InfoFormat(IFormatProvider provider, string format, params object[] args) => this._logger.InfoFormat(provider, format, args);

      public void Warn(object message) => this._logger.Warn(message);

      public void Warn(object message, Exception exception) => this._logger.Warn(message, exception);

      public void WarnFormat(string format, params object[] args) => this._logger.WarnFormat(format, args);

      public void WarnFormat(string format, object arg0) => this._logger.WarnFormat(format, arg0);

      public void WarnFormat(string format, object arg0, object arg1) => this._logger.WarnFormat(format, arg0, arg1);

      public void WarnFormat(string format, object arg0, object arg1, object arg2) => this._logger.WarnFormat(format, arg0, arg1, arg2);

      public void WarnFormat(IFormatProvider provider, string format, params object[] args) => this._logger.WarnFormat(provider, format, args);

      public void Error(object message) => this._logger.Error(message);

      public void Error(object message, Exception exception) => this._logger.Error(message, exception);

      public void ErrorFormat(string format, params object[] args) => this._logger.ErrorFormat(format, args);

      public void ErrorFormat(string format, object arg0) => this._logger.ErrorFormat(format, arg0);

      public void ErrorFormat(string format, object arg0, object arg1) => this._logger.ErrorFormat(format, arg0, arg1);

      public void ErrorFormat(string format, object arg0, object arg1, object arg2) => this._logger.ErrorFormat(format, arg0, arg1, arg2);

      public void ErrorFormat(IFormatProvider provider, string format, params object[] args) => this._logger.ErrorFormat(provider, format, args);

      public void Fatal(object message) => this._logger.Fatal(message);

      public void Fatal(object message, Exception exception) => this._logger.Fatal(message, exception);

      public void FatalFormat(string format, params object[] args) => this._logger.FatalFormat(format, args);

      public void FatalFormat(string format, object arg0) => this._logger.FatalFormat(format, arg0);

      public void FatalFormat(string format, object arg0, object arg1) => this._logger.FatalFormat(format, arg0, arg1);

      public void FatalFormat(string format, object arg0, object arg1, object arg2) => this._logger.FatalFormat(format, arg0, arg1, arg2);

      public void FatalFormat(IFormatProvider provider, string format, params object[] args) => this._logger.FatalFormat(provider, format, args);

      public bool IsDebugEnabled => this._logger.IsDebugEnabled;

      public bool IsErrorEnabled => this._logger.IsErrorEnabled;

      public Log4NetLogger()
        : this("Default")
      {
      }

      public Log4NetLogger(string name)
      {
        this._loggerName = name;
        this._logger = LogManager.GetLogger(name);
      }

      public Log4NetLogger(Type type)
      {
        this._loggerName = type.FullName;
        this._logger = LogManager.GetLogger(type);
      }

      public void SetNewLogFileSessionIfAny(
        Uri host,
        int sessionId,
        string prefix,
        string fileExtension)
      {
        foreach (IAppender appender in ((IEnumerable<IAppender>) ((LoggerRepositorySkeleton) LogManager.GetRepository()).GetAppenders()).Where<IAppender>((Func<IAppender, bool>) (x => x is FileAppender)))
        {
          if (appender is FileAppender fileAppender1)
          {
            string str1 = string.Empty;
            string str2 = string.Empty;
            if (host != (Uri) null)
            {
              str1 = host.Host + LoggerFactory.Log4NetLogger.separator;
              str2 = string.Format("{0}{1}", (object) host.Port, (object) LoggerFactory.Log4NetLogger.separator);
            }
            string str3 = sessionId != 0 ? string.Format("{0}{1}", (object) sessionId, (object) LoggerFactory.Log4NetLogger.separator) : string.Empty;
            string str4 = prefix + LoggerFactory.Log4NetLogger.separator + str1 + str2 + str3 + DateTime.Now.ToString(LoggerFactory.Log4NetLogger.dateTimeFormat) + "." + fileExtension;
            string str5 = fileAppender1.File.Contains("\\") ? fileAppender1.File.Substring(0, fileAppender1.File.LastIndexOf("\\", StringComparison.Ordinal) + 1) + str4 : str4;
            fileAppender1.File = str5;
            fileAppender1.ActivateOptions();
          }
        }
      }

      public log4net.Core.ILogger Logger { get; }

      public string GetLoggerPath()
      {
        string str = string.Empty;
        foreach (IAppender appender in this._logger.Logger.Repository.GetAppenders())
        {
          Type type = appender.GetType();
          if (type.Equals(typeof (FileAppender)) || type.Equals(typeof (RollingFileAppender)))
          {
            str = ((FileAppender) appender).File;
            break;
          }
        }
        return str;
      }

      public ILog GetLogger() => this._logger;
    }
  }
}
