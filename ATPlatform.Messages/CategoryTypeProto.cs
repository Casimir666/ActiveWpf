// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.CategoryTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum CategoryTypeProto
  {
    [OriginalName("UNDEFINED_CATEGORY_TYPE")] UndefinedCategoryType = 0,
    [OriginalName("FOREX")] Forex = 1,
    [OriginalName("CFD_LEVERAGE")] CfdLeverage = 2,
    [OriginalName("CFD_NO_LEVERAGE")] CfdNoLeverage = 4,
  }
}
