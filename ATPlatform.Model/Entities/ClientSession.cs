// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.ClientSession
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums;
using ATPlatform.Model.Enums.Symbol;
using System;

namespace ATPlatform.Model.Entities
{
  public class ClientSession : 
    IModel<ClientSession, string>,
    ICloneable<ClientSession>,
    IUpdatable<ClientSession>,
    Contracts.IEquatable<ClientSession>,
    IIdentify<string>,
    IModel
  {
    private string _key;

    public int AccountId { get; set; }

    public SessionActionType SessionActionType { get; set; }

    public DateTime Timestamp { get; set; }

    public int SessionIdHash { get; set; }

    public string IpAddress { get; set; }

    public int ProtocolVersionMajor { get; set; }

    public int ProtocolVersionMinor { get; set; }

    public int ProtocolVersionPatch { get; set; }

    public ClientApplicationType ClientApplicationType { get; set; }

    public string GetKey()
    {
      if (string.IsNullOrEmpty(this._key))
        this._key = string.Format("A{0}_S{1}_T{2}", (object) this.AccountId, (object) this.SessionIdHash, (object) this.SessionActionType);
      return this._key;
    }

    public ClientSession Clone()
    {
      ClientSession clientSession = new ClientSession();
      clientSession.Update(this);
      return clientSession;
    }

    public void Update(ClientSession other)
    {
      this.AccountId = other.AccountId;
      this.SessionActionType = other.SessionActionType;
      this.Timestamp = other.Timestamp;
      this.SessionIdHash = other.SessionIdHash;
      this.IpAddress = other.IpAddress;
      this.ProtocolVersionMajor = other.ProtocolVersionMajor;
      this.ProtocolVersionMinor = other.ProtocolVersionMinor;
      this.ProtocolVersionPatch = other.ProtocolVersionPatch;
      this.ClientApplicationType = other.ClientApplicationType;
    }

    public bool Equals(ClientSession other) => this.AccountId == other.AccountId && this.SessionActionType == other.SessionActionType && (this.Timestamp == other.Timestamp && this.SessionIdHash == other.SessionIdHash) && (this.IpAddress == other.IpAddress && this.ProtocolVersionMajor == other.ProtocolVersionMajor && (this.ProtocolVersionMinor == other.ProtocolVersionMinor && this.ProtocolVersionPatch == other.ProtocolVersionPatch)) && this.ClientApplicationType == other.ClientApplicationType;
  }
}
