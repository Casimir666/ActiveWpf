// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.Logging.ILogger
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using log4net;
using System;

namespace ATPlatform.Common.Utils.Logging
{
  public interface ILogger
  {
    void SetNewLogFileSessionIfAny(Uri host, int sessionId, string prefix, string fileExtension);

    ILog GetLogger();

    string GetLoggerPath();

    log4net.Core.ILogger Logger { get; }

    void Debug(object message);

    void Debug(object message, Exception exception);

    void DebugFormat(string format, params object[] args);

    void DebugFormat(string format, object arg0);

    void DebugFormat(string format, object arg0, object arg1);

    void DebugFormat(string format, object arg0, object arg1, object arg2);

    void DebugFormat(IFormatProvider provider, string format, params object[] args);

    void Info(object message);

    void Info(object message, Exception exception);

    void InfoFormat(string format, params object[] args);

    void InfoFormat(string format, object arg0);

    void InfoFormat(string format, object arg0, object arg1);

    void InfoFormat(string format, object arg0, object arg1, object arg2);

    void InfoFormat(IFormatProvider provider, string format, params object[] args);

    void Warn(object message);

    void Warn(object message, Exception exception);

    void WarnFormat(string format, params object[] args);

    void WarnFormat(string format, object arg0);

    void WarnFormat(string format, object arg0, object arg1);

    void WarnFormat(string format, object arg0, object arg1, object arg2);

    void WarnFormat(IFormatProvider provider, string format, params object[] args);

    void Error(object message);

    void Error(object message, Exception exception);

    void ErrorFormat(string format, params object[] args);

    void ErrorFormat(string format, object arg0);

    void ErrorFormat(string format, object arg0, object arg1);

    void ErrorFormat(string format, object arg0, object arg1, object arg2);

    void ErrorFormat(IFormatProvider provider, string format, params object[] args);

    void Fatal(object message);

    void Fatal(object message, Exception exception);

    void FatalFormat(string format, params object[] args);

    void FatalFormat(string format, object arg0);

    void FatalFormat(string format, object arg0, object arg1);

    void FatalFormat(string format, object arg0, object arg1, object arg2);

    void FatalFormat(IFormatProvider provider, string format, params object[] args);

    bool IsDebugEnabled { get; }

    bool IsInfoEnabled { get; }

    bool IsWarnEnabled { get; }

    bool IsErrorEnabled { get; }

    bool IsFatalEnabled { get; }
  }
}
