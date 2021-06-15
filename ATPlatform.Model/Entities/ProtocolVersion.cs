// Decompiled with JetBrains decompiler
// Type: ATPlatform.Model.Entities.ProtocolVersion
// Assembly: ATPlatform.Model, Version=3.20.2.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: D195563B-B1EE-432B-B0D1-4AD275ADD268
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Model.dll

using ATPlatform.Model.Contracts;

namespace ATPlatform.Model.Entities
{
  public class ProtocolVersion : IEquatable<ProtocolVersion>
  {
    public int Major { get; set; }

    public int Minor { get; set; }

    public int Patch { get; set; }

    public bool Equals(ProtocolVersion other) => this.Major == other.Major && this.Minor == other.Minor && this.Patch == other.Patch;
  }
}
