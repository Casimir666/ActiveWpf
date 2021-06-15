﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.ProtoConverters.ProtoNullableStringConverter
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

namespace ATPlatform.Common.ProtoConverters
{
  public static class ProtoNullableStringConverter
  {
    public static string GetFromProto(string protoValue) => !string.IsNullOrEmpty(protoValue) ? protoValue : (string) null;

    public static string GetFromModel(string modelValue) => modelValue ?? string.Empty;
  }
}
