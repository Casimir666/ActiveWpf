// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Proto.Providers.ModelProtoPapaProvider
// Assembly: ATPlatform.Model.Proto, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: E6EBFA31-5E2E-466E-951D-D831D69BD6FA
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.Proto.dll

using ATPlatform.Model.Proto.Contracts;
using System;

namespace ATPlatform.Model.Proto.Providers
{
  public class ModelProtoPapaProvider : IDisposable, IPapaProvider
  {
    private static IPapaProvider _papaProvider;
    private IProtoMapperProvider _protoMapperProvider;
    private bool _disposed;

    private ModelProtoPapaProvider()
    {
      ProtoMapperProvider protoProvider = new ProtoMapperProvider();
      this._protoMapperProvider = (IProtoMapperProvider) protoProvider;
      ProtoMapperInitializer.Initialize(protoProvider);
    }

    public static IPapaProvider GetInstance()
    {
      if (ModelProtoPapaProvider._papaProvider == null)
        ModelProtoPapaProvider._papaProvider = (IPapaProvider) new ModelProtoPapaProvider();
      return ModelProtoPapaProvider._papaProvider;
    }

    public IProtoMapperProvider GetProtoMapperProvider() => this._protoMapperProvider;

    public void Dispose()
    {
      if (this._disposed)
        return;
      this._disposed = true;
      this._protoMapperProvider = (IProtoMapperProvider) null;
    }
  }
}
