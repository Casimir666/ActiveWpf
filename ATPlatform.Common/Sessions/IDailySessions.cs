﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Sessions.IDailySessions
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;

namespace ATPlatform.Common.Sessions
{
  public interface IDailySessions
  {
    TimeZoneInfo TimeZoneInfo { get; }

    bool HasActiveSession();

    bool HasActiveSession(DateTime? expirationDateTime);
  }
}
