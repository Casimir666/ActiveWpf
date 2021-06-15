// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.ProtoConverters.ProtoNullableNumberConverter
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

namespace ATPlatform.Common.ProtoConverters
{
  public static class ProtoNullableNumberConverter
  {
    public static int? GetFromProto(int protoValue) => protoValue <= 0 ? new int?() : new int?(protoValue);

    public static int GetFromModel(int? modelValue) => modelValue.GetValueOrDefault();

    public static long? GetFromProto(long protoValue) => protoValue <= 0L ? new long?() : new long?(protoValue);

    public static long GetFromModel(long? modelValue) => modelValue.GetValueOrDefault();

    public static double? GetFromProto(double protoValue) => protoValue <= 0.0 ? new double?() : new double?(protoValue);

    public static double GetFromModel(double? modelValue) => modelValue.GetValueOrDefault();
  }
}
