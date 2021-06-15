// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.Providers.ProtoMapperProvider
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Model.Proto.Contracts;
using Google.Protobuf;
using System;
using System.Collections.Generic;

namespace ATPlatform.Model.Proto.Providers
{
  internal class ProtoMapperProvider : IProtoMapperProvider
  {
    private readonly Dictionary<Type, Dictionary<Type, object>> _mappers;

    internal ProtoMapperProvider() => this._mappers = new Dictionary<Type, Dictionary<Type, object>>();

    public IProtoMapper<TProto, TModel> GetMapper<TProto, TModel>() where TProto : IMessage, IMessage<TProto> => (IProtoMapper<TProto, TModel>) this._mappers[typeof (TProto)][typeof (TModel)];

    internal void Register<TProto, TModel>(IProtoMapper<TProto, TModel> mapper) where TProto : IMessage, IMessage<TProto>
    {
      Type key1 = typeof (TProto);
      Type key2 = typeof (TModel);
      if (!this._mappers.ContainsKey(key1))
        this._mappers[key1] = new Dictionary<Type, object>();
      if (this._mappers[key1].ContainsKey(key2))
        throw new Exception("Mapper of types " + key1.Name + "->" + key2.Name + " is already registered");
      this._mappers[key1][key2] = (object) mapper;
    }
  }
}
