﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.Threading.ThreadingExtensions
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;
using System.Threading.Tasks;

namespace ATPlatform.Common.Utils.Threading
{
  public static class ThreadingExtensions
  {
    public static T ExecuteOnThreadPoolAndGetResult<T>(this Task<T> t) => Task.Run<T>((Func<Task<T>>) (async () => await t)).Result;
  }
}