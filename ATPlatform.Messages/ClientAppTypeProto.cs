// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.ClientAppTypeProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf.Reflection;

namespace ATPlatform.IDL
{
  public enum ClientAppTypeProto
  {
    [OriginalName("UNKNOWN_CLIENT_APP")] UnknownClientApp,
    [OriginalName("PERSONAL_AREA")] PersonalArea,
    [OriginalName("WEB_PLATFORM")] WebPlatform,
    [OriginalName("IOS")] Ios,
    [OriginalName("ANDROID")] Android,
    [OriginalName("PERSONAL_AREA_ADMIN")] PersonalAreaAdmin,
    [OriginalName("IPAD")] Ipad,
    [OriginalName("ANDROID_TABLET")] AndroidTablet,
    [OriginalName("IPHONE")] Iphone,
    [OriginalName("ANDROID_PHONE")] AndroidPhone,
    [OriginalName("CLIENT_API")] ClientApi,
  }
}
