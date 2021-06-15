// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Defaults.ClientMessage
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;

namespace ATPlatform.Common.Defaults
{
  public static class ClientMessage
  {
    public static int SubjectBytesMaxLength = 1024;
    public static int BodyBytesMaxLength = 128000;
    public static int OneTimeOnlyNotificationSubjectBytesMaxLength = 512;
    public static int OneTimeOnlyNotificationBodyBytesMaxLength = 2048;
    public static readonly TimeSpan FutureSendClientMessageMinimumValue = TimeSpan.FromMinutes(15.0);
    public static readonly TimeSpan FutureSendClientMessagesCheckInterval = TimeSpan.FromMinutes(1.0);
  }
}
