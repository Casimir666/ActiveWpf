﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Contracts.ISymbolOrGroupRelated
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

namespace ATPlatform.Model.Contracts
{
  public interface ISymbolOrGroupRelated
  {
    string SymbolId { get; set; }

    int? TagId { get; set; }

    int? SymbolGroupId { get; set; }
  }
}
