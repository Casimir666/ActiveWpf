// Decompiled with JetBrains decompiler
// Type: ActivTrades.ActivTrader.Lightstreamer.Logging.LSLoggerProvider
// Assembly: ActivTrades.ActivTrader.Client.API, Version=3.20.0.9368, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 1DDD33EC-7764-4260-B8CC-81E638C549BC
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ActivTrades.ActivTrader.Client.API.dll

using Lightstreamer.DotNet.Client.Log;
using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace ActivTrades.ActivTrader.Lightstreamer.Logging
{
  public class LSLoggerProvider : ILoggerProvider
  {
    private readonly ConcurrentDictionary<string, ILogger> loggers = new ConcurrentDictionary<string, ILogger>();

    public ILogger GetLogger(string category)
    {
      ILogger logger;
      if (!this.loggers.TryGetValue(category, out logger))
      {
        ILogger addValue = (ILogger) new LSLoggerProvider.LsLogger();
        logger = this.loggers.AddOrUpdate(category, addValue, (Func<string, ILogger, ILogger>) ((k, v) => v));
      }
      return logger;
    }

    internal class LsLogger : ILogger
    {
      private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

      public bool IsDebugEnabled => LSLoggerProvider.LsLogger.logger.IsDebugEnabled;

      public bool IsInfoEnabled => LSLoggerProvider.LsLogger.logger.IsInfoEnabled;

      public bool IsWarnEnabled => LSLoggerProvider.LsLogger.logger.IsWarnEnabled;

      public bool IsErrorEnabled => LSLoggerProvider.LsLogger.logger.IsErrorEnabled;

      public bool IsFatalEnabled => LSLoggerProvider.LsLogger.logger.IsFatalEnabled;

      public void Debug(string line) => LSLoggerProvider.LsLogger.logger.Debug((object) line);

      public void Debug(string line, Exception exception) => LSLoggerProvider.LsLogger.logger.Debug((object) line, exception);

      public void Error(string line) => LSLoggerProvider.LsLogger.logger.Error((object) line);

      public void Error(string line, Exception exception) => LSLoggerProvider.LsLogger.logger.Error((object) line, exception);

      public void Fatal(string line) => LSLoggerProvider.LsLogger.logger.Fatal((object) line);

      public void Fatal(string line, Exception exception) => LSLoggerProvider.LsLogger.logger.Fatal((object) line, exception);

      public void Info(string line) => LSLoggerProvider.LsLogger.logger.Info((object) line);

      public void Info(string line, Exception exception) => LSLoggerProvider.LsLogger.logger.Info((object) line, exception);

      public void Warn(string line) => LSLoggerProvider.LsLogger.logger.Warn((object) line);

      public void Warn(string line, Exception exception) => LSLoggerProvider.LsLogger.logger.Warn((object) line, exception);
    }
  }
}
