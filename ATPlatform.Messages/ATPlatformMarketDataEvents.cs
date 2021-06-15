// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.MarketDataEvents.ATPlatformMarketDataEventsReflection
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;

namespace ATPlatform.IDL.MarketDataEvents
{
  public static class ATPlatformMarketDataEventsReflection
  {
    private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFBVFBsYXRmb3JtLk1hcmtldERhdGFFdmVudHMucHJvdG8SH0FUUGxhdGZv" + "cm0uSURMLk1hcmtldERhdGFFdmVudHMaF0FUUGxhdGZvcm0uQ29tbW9uLnBy" + "b3RvIp4CChRNYXJrZXREYXRhRXZlbnRQcm90bxIKCgJpZBgBIAEoBRJZChZt" + "YXJrZXRfZGF0YV9ldmVudF90eXBlGAIgASgOMjkuQVRQbGF0Zm9ybS5JREwu" + "TWFya2V0RGF0YUV2ZW50cy5NYXJrZXREYXRhRXZlbnRUeXBlUHJvdG8SDAoE" + "bmFtZRgDIAEoCRJJCgVzdGF0ZRgEIAEoDjI6LkFUUGxhdGZvcm0uSURMLk1h" + "cmtldERhdGFFdmVudHMuTWFya2V0RGF0YUV2ZW50U3RhdGVQcm90bxIPCgdT" + "dWJqZWN0GAUgASgJEgwKBEJvZHkYBiABKAkSEQoJdGltZXN0YW1wGAcgASgD" + "EhQKDGluaXRpYXRvcl9pZBgIIAEoCSKHAQocTWFya2V0RGF0YUV2ZW50U2V0" + "dGluZ3NQcm90bxIKCgJpZBgBIAEoBRIcChRtYXJrZXRfZGF0YV9ldmVudF9p" + "ZBgCIAEoBRILCgNrZXkYAyABKAkSDQoFdmFsdWUYBCABKAkSDAoEdHlwZRgF" + "IAEoCRITCgtkZXNjcmlwdGlvbhgGIAEoCSJ8Ch9NYXJrZXREYXRhRXZlbnRU" + "cmFuc2xhdGlvblByb3RvEgoKAmlkGAEgASgFEhwKFG1hcmtldF9kYXRhX2V2" + "ZW50X2lkGAIgASgFEhAKCGxhbmd1YWdlGAMgASgJEg8KB3N1YmplY3QYBCAB" + "KAkSDAoEYm9keRgFIAEoCSJ9ChdNYXJrZXREYXRhRXZlbnRUYWdQcm90bxIK" + "CgJpZBgBIAEoBRIcChRtYXJrZXRfZGF0YV9ldmVudF9pZBgCIAEoBRIpCgN0" + "YWcYAyABKA4yHC5BVFBsYXRmb3JtLklETC5UYWdUeXBlUHJvdG8SDQoFdmFs" + "dWUYBCABKAki0gEKG01hcmtldERhdGFFdmVudEhpc3RvcnlQcm90bxIKCgJp" + "ZBgBIAEoBRIcChRtYXJrZXRfZGF0YV9ldmVudF9pZBgCIAEoBRJJCgVzdGF0" + "ZRgDIAEoDjI6LkFUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHMuTWFy" + "a2V0RGF0YUV2ZW50U3RhdGVQcm90bxIRCgl0aW1lc3RhbXAYBCABKAMSFAoM" + "aW5pdGlhdG9yX2lkGAUgASgJEhUKDWRhdGFfc25hcHNob3QYBiABKAki4gQK" + "G01hcmtldERhdGFFdmVudFJlcXVlc3RQcm90bxJQChFtYXJrZXRfZGF0YV9l" + "dmVudBgBIAEoCzI1LkFUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHMu" + "TWFya2V0RGF0YUV2ZW50UHJvdG8SXAoIc2V0dGluZ3MYAiADKAsySi5BVFBs" + "YXRmb3JtLklETC5NYXJrZXREYXRhRXZlbnRzLk1hcmtldERhdGFFdmVudFJl" + "cXVlc3RQcm90by5TZXR0aW5nc0VudHJ5EmQKDHRyYW5zbGF0aW9ucxgDIAMo" + "CzJOLkFUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHMuTWFya2V0RGF0" + "YUV2ZW50UmVxdWVzdFByb3RvLlRyYW5zbGF0aW9uc0VudHJ5EkYKBHRhZ3MY" + "BCADKAsyOC5BVFBsYXRmb3JtLklETC5NYXJrZXREYXRhRXZlbnRzLk1hcmtl" + "dERhdGFFdmVudFRhZ1Byb3RvGm4KDVNldHRpbmdzRW50cnkSCwoDa2V5GAEg" + "ASgJEkwKBXZhbHVlGAIgASgLMj0uQVRQbGF0Zm9ybS5JREwuTWFya2V0RGF0" + "YUV2ZW50cy5NYXJrZXREYXRhRXZlbnRTZXR0aW5nc1Byb3RvOgI4ARp1ChFU" + "cmFuc2xhdGlvbnNFbnRyeRILCgNrZXkYASABKAkSTwoFdmFsdWUYAiABKAsy" + "QC5BVFBsYXRmb3JtLklETC5NYXJrZXREYXRhRXZlbnRzLk1hcmtldERhdGFF" + "dmVudFRyYW5zbGF0aW9uUHJvdG86AjgBIpIGCiBNYXJrZXREYXRhRXZlbnRO" + "b3RpZmljYXRpb25Qcm90bxJQChFtYXJrZXRfZGF0YV9ldmVudBgBIAEoCzI1" + "LkFUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHMuTWFya2V0RGF0YUV2" + "ZW50UHJvdG8SYQoIc2V0dGluZ3MYAiADKAsyTy5BVFBsYXRmb3JtLklETC5N" + "YXJrZXREYXRhRXZlbnRzLk1hcmtldERhdGFFdmVudE5vdGlmaWNhdGlvblBy" + "b3RvLlNldHRpbmdzRW50cnkSaQoMdHJhbnNsYXRpb25zGAMgAygLMlMuQVRQ" + "bGF0Zm9ybS5JREwuTWFya2V0RGF0YUV2ZW50cy5NYXJrZXREYXRhRXZlbnRO" + "b3RpZmljYXRpb25Qcm90by5UcmFuc2xhdGlvbnNFbnRyeRJGCgR0YWdzGAQg" + "AygLMjguQVRQbGF0Zm9ybS5JREwuTWFya2V0RGF0YUV2ZW50cy5NYXJrZXRE" + "YXRhRXZlbnRUYWdQcm90bxJqCg1zbmFwc2hvdF9kYXRhGAUgAygLMlMuQVRQ" + "bGF0Zm9ybS5JREwuTWFya2V0RGF0YUV2ZW50cy5NYXJrZXREYXRhRXZlbnRO" + "b3RpZmljYXRpb25Qcm90by5TbmFwc2hvdERhdGFFbnRyeRpuCg1TZXR0aW5n" + "c0VudHJ5EgsKA2tleRgBIAEoCRJMCgV2YWx1ZRgCIAEoCzI9LkFUUGxhdGZv" + "cm0uSURMLk1hcmtldERhdGFFdmVudHMuTWFya2V0RGF0YUV2ZW50U2V0dGlu" + "Z3NQcm90bzoCOAEadQoRVHJhbnNsYXRpb25zRW50cnkSCwoDa2V5GAEgASgJ" + "Ek8KBXZhbHVlGAIgASgLMkAuQVRQbGF0Zm9ybS5JREwuTWFya2V0RGF0YUV2" + "ZW50cy5NYXJrZXREYXRhRXZlbnRUcmFuc2xhdGlvblByb3RvOgI4ARozChFT" + "bmFwc2hvdERhdGFFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6" + "AjgBIj4KHkdldE1hcmtldERhdGFFdmVudFJlcXVlc3RQcm90bxIcChRtYXJr" + "ZXRfZGF0YV9ldmVudF9pZBgBIAEoBSKYAgoeR2V0TWFya2V0RGF0YUV2ZW50" + "c0ZpbHRlclByb3RvEhoKEnByZWZlcnJlZF9sYW5ndWFnZRgBIAEoCRIRCglm" + "cm9tX2RhdGUYAiABKAMSDwoHdG9fZGF0ZRgDIAEoAxJICgV0eXBlcxgEIAMo" + "DjI5LkFUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHMuTWFya2V0RGF0" + "YUV2ZW50VHlwZVByb3RvEkoKBnN0YXRlcxgFIAMoDjI6LkFUUGxhdGZvcm0u" + "SURMLk1hcmtldERhdGFFdmVudHMuTWFya2V0RGF0YUV2ZW50U3RhdGVQcm90" + "bxIMCgR0ZXh0GAYgASgJEhIKCmluaXRpYXRvcnMYByADKAkijgEKH0dldE1h" + "cmtldERhdGFFdmVudHNSZXF1ZXN0UHJvdG8SDAoEc2tpcBgBIAEoBRIMCgR0" + "YWtlGAIgASgFEk8KBmZpbHRlchgDIAEoCzI/LkFUUGxhdGZvcm0uSURMLk1h" + "cmtldERhdGFFdmVudHMuR2V0TWFya2V0RGF0YUV2ZW50c0ZpbHRlclByb3Rv" + "IsEBCiRHZXRNYXJrZXREYXRhRXZlbnRzTm90aWZpY2F0aW9uUHJvdG8SUQoS" + "bWFya2V0X2RhdGFfZXZlbnRzGAEgAygLMjUuQVRQbGF0Zm9ybS5JREwuTWFy" + "a2V0RGF0YUV2ZW50cy5NYXJrZXREYXRhRXZlbnRQcm90bxJGCgR0YWdzGAIg" + "AygLMjguQVRQbGF0Zm9ybS5JREwuTWFya2V0RGF0YUV2ZW50cy5NYXJrZXRE" + "YXRhRXZlbnRUYWdQcm90byJhCiVHZXRNYXJrZXREYXRhRXZlbnRIaXN0b3J5" + "UmVxdWVzdFByb3RvEgwKBHNraXAYASABKAUSDAoEdGFrZRgCIAEoBRIcChRt" + "YXJrZXRfZGF0YV9ldmVudF9pZBgDIAEoBSJ7CipHZXRNYXJrZXREYXRhRXZl" + "bnRIaXN0b3J5Tm90aWZpY2F0aW9uUHJvdG8STQoHaGlzdG9yeRgBIAMoCzI8" + "LkFUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHMuTWFya2V0RGF0YUV2" + "ZW50SGlzdG9yeVByb3RvKu8BChhNYXJrZXREYXRhRXZlbnRUeXBlUHJvdG8S" + "JAogVU5ERUZJTkVEX01BUktFVF9EQVRBX0VWRU5UX1RZUEUQABIeChpQUklD" + "RV9SSVNFX1BFUkNFTlRBR0VfVFlQRRABEh8KG1BSSUNFX0ZBTExTX1BFUkNF" + "TlRBR0VfVFlQRRACEhwKGFBSSUNFX0hJR0hfVFJFU0hPTERfVFlQRRADEhsK" + "F1BSSUNFX0xPV19UUkVTSE9MRF9UWVBFEAQSGQoVUkVTSVNUQU5DRV9MRVZF" + "TF9UWVBFEAUSFgoSU1VQUE9SVF9MRVZFTF9UWVBFEAYqjwEKGU1hcmtldERh" + "dGFFdmVudFN0YXRlUHJvdG8SEwoPVU5ERUZJTkVEX1NUQVRFEAASEgoOSU5B" + "Q1RJVkVfU1RBVEUQARIQCgxBQ1RJVkVfU1RBVEUQAhITCg9DT01QTEVURURf" + "U1RBVEUQAxIPCgtFUlJPUl9TVEFURRAEEhEKDURFTEVURURfU1RBVEUQBUJT" + "Cg5hdHBsYXRmb3JtLmlkbEIaQVRQbGF0Zm9ybU1hcmtldERhdGFFdmVudHNI" + "AfgBAaoCH0FUUGxhdGZvcm0uSURMLk1hcmtldERhdGFFdmVudHNiBnByb3Rv" + "Mw=="), new FileDescriptor[1]
    {
      ATPlatformCommonReflection.Descriptor
    }, new GeneratedClrTypeInfo(new System.Type[2]
    {
      typeof (MarketDataEventTypeProto),
      typeof (MarketDataEventStateProto)
    }, new GeneratedClrTypeInfo[13]
    {
      new GeneratedClrTypeInfo(typeof (MarketDataEventProto), (MessageParser) MarketDataEventProto.Parser, new string[8]
      {
        "Id",
        "MarketDataEventType",
        "Name",
        "State",
        "Subject",
        "Body",
        "Timestamp",
        "InitiatorId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (MarketDataEventSettingsProto), (MessageParser) MarketDataEventSettingsProto.Parser, new string[6]
      {
        "Id",
        "MarketDataEventId",
        "Key",
        "Value",
        "Type",
        "Description"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (MarketDataEventTranslationProto), (MessageParser) MarketDataEventTranslationProto.Parser, new string[5]
      {
        "Id",
        "MarketDataEventId",
        "Language",
        "Subject",
        "Body"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (MarketDataEventTagProto), (MessageParser) MarketDataEventTagProto.Parser, new string[4]
      {
        "Id",
        "MarketDataEventId",
        "Tag",
        "Value"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (MarketDataEventHistoryProto), (MessageParser) MarketDataEventHistoryProto.Parser, new string[6]
      {
        "Id",
        "MarketDataEventId",
        "State",
        "Timestamp",
        "InitiatorId",
        "DataSnapshot"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (MarketDataEventRequestProto), (MessageParser) MarketDataEventRequestProto.Parser, new string[4]
      {
        "MarketDataEvent",
        "Settings",
        "Translations",
        "Tags"
      }, (string[]) null, (System.Type[]) null, new GeneratedClrTypeInfo[2]),
      new GeneratedClrTypeInfo(typeof (MarketDataEventNotificationProto), (MessageParser) MarketDataEventNotificationProto.Parser, new string[5]
      {
        "MarketDataEvent",
        "Settings",
        "Translations",
        "Tags",
        "SnapshotData"
      }, (string[]) null, (System.Type[]) null, new GeneratedClrTypeInfo[3]),
      new GeneratedClrTypeInfo(typeof (GetMarketDataEventRequestProto), (MessageParser) GetMarketDataEventRequestProto.Parser, new string[1]
      {
        "MarketDataEventId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetMarketDataEventsFilterProto), (MessageParser) GetMarketDataEventsFilterProto.Parser, new string[7]
      {
        "PreferredLanguage",
        "FromDate",
        "ToDate",
        "Types_",
        "States",
        "Text",
        "Initiators"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetMarketDataEventsRequestProto), (MessageParser) GetMarketDataEventsRequestProto.Parser, new string[3]
      {
        "Skip",
        "Take",
        "Filter"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetMarketDataEventsNotificationProto), (MessageParser) GetMarketDataEventsNotificationProto.Parser, new string[2]
      {
        "MarketDataEvents",
        "Tags"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetMarketDataEventHistoryRequestProto), (MessageParser) GetMarketDataEventHistoryRequestProto.Parser, new string[3]
      {
        "Skip",
        "Take",
        "MarketDataEventId"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetMarketDataEventHistoryNotificationProto), (MessageParser) GetMarketDataEventHistoryNotificationProto.Parser, new string[1]
      {
        "History"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null)
    }));

    public static FileDescriptor Descriptor => ATPlatformMarketDataEventsReflection.descriptor;
  }
}
