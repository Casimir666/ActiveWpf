// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.ServerPublicInfo
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;
using ATPlatform.Model.Enums;

namespace ATPlatform.Model.Entities
{
  public class ServerPublicInfo : 
    ICloneable<ServerPublicInfo>,
    IUpdatable<ServerPublicInfo>,
    IEquatable<ServerPublicInfo>
  {
    public virtual ATPlatform.Common.Defaults.Enums.PlatformTimeZone PlatformTimeZone { get; set; }

    public virtual PlatformType PlatformType { get; set; }

    public virtual ProtocolVersion ProtocolVersion { get; set; }

    public virtual ServerPublicInfo Clone()
    {
      ServerPublicInfo serverPublicInfo = new ServerPublicInfo();
      serverPublicInfo.Update(this);
      return serverPublicInfo;
    }

    public virtual void Update(ServerPublicInfo other)
    {
      this.PlatformTimeZone = other.PlatformTimeZone;
      this.PlatformType = other.PlatformType;
      this.ProtocolVersion = other.ProtocolVersion;
    }

    public virtual bool Equals(ServerPublicInfo other) => this.PlatformTimeZone == other.PlatformTimeZone && this.PlatformType == other.PlatformType && this.ProtocolVersion.Equals(other.ProtocolVersion);
  }
}
