﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.Contracts.IProtoMapper`2
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using Google.Protobuf;

namespace ATPlatform.Model.Proto.Contracts
{
  public interface IProtoMapper<TProto, TModel> where TProto : IMessage, IMessage<TProto>
  {
    TProto ProtoFromModel(TModel model);

    TModel ModelFromProto(TProto proto);
  }
}
