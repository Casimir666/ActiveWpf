// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.DoubleComparer
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;

namespace ATPlatform.Common.Utils
{
  public static class DoubleComparer
  {
    public static bool AreEqual(double left, double right) => Math.Abs(left - right) < double.Epsilon;

    public static bool AreEqual(double? left, double? right) => left.HasValue && right.HasValue && Math.Abs(left.Value - right.Value) < double.Epsilon;
  }
}
