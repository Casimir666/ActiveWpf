// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.HedgingBridge.ATPlatformHedgingBridgeReflection
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;

namespace ATPlatform.IDL.HedgingBridge
{
  public static class ATPlatformHedgingBridgeReflection
  {
    private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5BVFBsYXRmb3JtLkhlZGdpbmdCcmlkZ2UucHJvdG8SFUFUUGxhdGZvcm0u" + "SURMLkJyaWRnZRoXQVRQbGF0Zm9ybS5Db21tb24ucHJvdG8ipwIKF0JyaWRn" + "ZU9yZGVyUmVxdWVzdFByb3RvEg4KBnN5bWJvbBgBIAEoCRIOCgZ2b2x1bWUY" + "AiABKAMSDQoFcHJpY2UYAyABKAESLAoEdHlwZRgEIAEoDjIeLkFUUGxhdGZv" + "cm0uSURMLk9yZGVyVHlwZVByb3RvEhIKCmFjY291bnRfaWQYBSABKAUSFQoN" + "Y29udHJhY3Rfc2l6ZRgGIAEoARIaChJoZWRnZV9zZXR0aW5nc19zZXQYByAB" + "KAkSFQoNc3ltYm9sX2RpZ2l0cxgIIAEoBRIgChhoZWRnZV9saXF1aWRpdHlf" + "cHJvdmlkZXIYCSABKAkSGgoSYWNjdW11bGF0ZWRfdm9sdW1lGAogASgDEhMK" + "C2NvZWZmaWNpZW50GAsgASgBIkkKHEJyaWRnZU9yZGVyTm90aWZpY2F0aW9u" + "UHJvdG8SCgoCaWQYASABKAMSDQoFcHJpY2UYAiABKAESDgoGc3ltYm9sGAMg" + "ASgJIsIBCh1CcmlkZ2VNYXJnaW5DaGVja1JlcXVlc3RQcm90bxIOCgZzeW1i" + "b2wYASABKAkSDgoGdm9sdW1lGAIgASgFEgsKA2FzaxgDIAEoARILCgNiaWQY" + "BCABKAESEgoKYWNjb3VudF9pZBgFIAEoBRIaChJoZWRnZV9zZXR0aW5nc19z" + "ZXQYBiABKAkSIAoYaGVkZ2VfbGlxdWlkaXR5X3Byb3ZpZGVyGAcgASgJEhUK" + "DXN5bWJvbF9kaWdpdHMYCCABKAUiWgoiQnJpZGdlTWFyZ2luQ2hlY2tOb3Rp" + "ZmljYXRpb25Qcm90bxIKCgJpZBgBIAEoAxILCgNhc2sYAiABKAESCwoDYmlk" + "GAMgASgBEg4KBnN5bWJvbBgEIAEoCSK0AQoSTGV2ZWwyUHJpY2VSZXF1ZXN0" + "Eg4KBnN5bWJvbBgBIAEoCRIOCgZ2b2x1bWUYAiABKAMSDQoFcHJpY2UYAyAB" + "KAESLAoEdHlwZRgEIAEoDjIeLkFUUGxhdGZvcm0uSURMLk9yZGVyVHlwZVBy" + "b3RvEhEKCXJlcXVlc3RJZBgFIAEoAxIZChFhY2N1bXVsYXRlZFZvbHVtZRgG" + "IAEoAxITCgtjb2VmZmljaWVudBgHIAEoASI7ChdMZXZlbDJQcmljZU5vdGlm" + "aWNhdGlvbhINCgVwcmljZRgBIAEoARIRCglyZXF1ZXN0SWQYAiABKAMiZwoY" + "TGV2ZWwyTWFyZ2luQ2hlY2tSZXF1ZXN0Eg4KBnN5bWJvbBgBIAEoCRIOCgZ2" + "b2x1bWUYAiABKAUSCwoDYXNrGAMgASgBEgsKA2JpZBgEIAEoARIRCglyZXF1" + "ZXN0SWQYBSABKAMiTAodTGV2ZWwyTWFyZ2luQ2hlY2tOb3RpZmljYXRpb24S" + "CwoDYXNrGAEgASgBEgsKA2JpZBgCIAEoARIRCglyZXF1ZXN0SWQYAyABKAMi" + "ZQocQnJpZGdlRXJyb3JOb3RpZmljYXRpb25Qcm90bxIyCgplcnJvcl9jb2Rl" + "GAEgASgOMh4uQVRQbGF0Zm9ybS5JREwuRXJyb3JDb2RlUHJvdG8SEQoJcmVx" + "dWVzdElkGAIgASgDKkkKH0JyaWRnZVByb3RvY29sVmVyc2lvbk1ham9yUHJv" + "dG8SEwoPVU5ERUZJTkVEX01BSk9SEAASEQoNVkVSU0lPTl9NQUpPUhABKkkK" + "H0JyaWRnZVByb3RvY29sVmVyc2lvbk1pbm9yUHJvdG8SEwoPVU5ERUZJTkVE" + "X01JTk9SEAASEQoNVkVSU0lPTl9NSU5PUhADKkkKH0JyaWRnZVByb3RvY29s" + "VmVyc2lvblBhdGNoUHJvdG8SEwoPVU5ERUZJTkVEX1BBVENIEAASEQoNVkVS" + "U0lPTl9QQVRDSBABQiRIAfgBAaoCHEFUUGxhdGZvcm0uSURMLkhlZGdpbmdC" + "cmlkZ2ViBnByb3RvMw=="), new FileDescriptor[1]
    {
      ATPlatformCommonReflection.Descriptor
    }, new GeneratedClrTypeInfo(new System.Type[3]
    {
      typeof (BridgeProtocolVersionMajorProto),
      typeof (BridgeProtocolVersionMinorProto),
      typeof (BridgeProtocolVersionPatchProto)
    }, new GeneratedClrTypeInfo[9]
    {
      new GeneratedClrTypeInfo(typeof (BridgeOrderRequestProto), (MessageParser) BridgeOrderRequestProto.Parser, new string[11]
      {
        "Symbol",
        "Volume",
        "Price",
        "Type",
        "AccountId",
        "ContractSize",
        "HedgeSettingsSet",
        "SymbolDigits",
        "HedgeLiquidityProvider",
        "AccumulatedVolume",
        "Coefficient"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (BridgeOrderNotificationProto), (MessageParser) BridgeOrderNotificationProto.Parser, new string[3]
      {
        "Id",
        "Price",
        "Symbol"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (BridgeMarginCheckRequestProto), (MessageParser) BridgeMarginCheckRequestProto.Parser, new string[8]
      {
        "Symbol",
        "Volume",
        "Ask",
        "Bid",
        "AccountId",
        "HedgeSettingsSet",
        "HedgeLiquidityProvider",
        "SymbolDigits"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (BridgeMarginCheckNotificationProto), (MessageParser) BridgeMarginCheckNotificationProto.Parser, new string[4]
      {
        "Id",
        "Ask",
        "Bid",
        "Symbol"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (Level2PriceRequest), (MessageParser) Level2PriceRequest.Parser, new string[7]
      {
        "Symbol",
        "Volume",
        "Price",
        "Type",
        "RequestId",
        "AccumulatedVolume",
        "Coefficient"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (Level2PriceNotification), (MessageParser) Level2PriceNotification.Parser, new string[2]
      {
        "Price",
        "RequestId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (Level2MarginCheckRequest), (MessageParser) Level2MarginCheckRequest.Parser, new string[5]
      {
        "Symbol",
        "Volume",
        "Ask",
        "Bid",
        "RequestId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (Level2MarginCheckNotification), (MessageParser) Level2MarginCheckNotification.Parser, new string[3]
      {
        "Ask",
        "Bid",
        "RequestId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (BridgeErrorNotificationProto), (MessageParser) BridgeErrorNotificationProto.Parser, new string[2]
      {
        "ErrorCode",
        "RequestId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null)
    }));

    public static FileDescriptor Descriptor => ATPlatformHedgingBridgeReflection.descriptor;
  }
}
