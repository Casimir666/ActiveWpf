// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.ATPlatformAbuseAlertReflection
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;

namespace ATPlatform.IDL.AbuseAlert
{
  public static class ATPlatformAbuseAlertReflection
  {
    private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtBVFBsYXRmb3JtLkFidXNlQWxlcnQucHJvdG8SGUFUUGxhdGZvcm0uSURM" + "LkFidXNlQWxlcnQaF0FUUGxhdGZvcm0uQ29tbW9uLnByb3RvIrACCiFBYnVz" + "ZUFsZXJ0U3RhdGVsZXNzQWxlcnREYXRhUHJvdG8SCgoCaWQYASABKAUSEQoJ" + "cnVsZV9jb2RlGAIgASgFEhEKCXJ1bGVfbmFtZRgDIAEoCRISCgphY2NvdW50" + "X2lkGAQgASgFEhEKCWFsZXJ0X2tleRgFIAEoCRIRCgl0aW1lc3RhbXAYBiAB" + "KAMSFQoNZGF0YV9zbmFwc2hvdBgHIAEoCRIZChFzZXR0aW5nc19zbmFwc2hv" + "dBgIIAEoCRIXCg9hZGRpdGlvbmFsX2RhdGEYCSADKAkSFAoMYWNjb3VudF9u" + "YW1lGAogASgJEh4KFmFjY291bnRfdHJhZGVfc2V0dGluZ3MYCyABKAkSHgoW" + "YWNjb3VudF9oZWRnZV9zZXR0aW5ncxgMIAEoCSKrAQoYQWJ1c2VBbGVydFN0" + "YXRlRGF0YVByb3RvEhAKCGFsZXJ0X2lkGAEgASgFEj0KBXN0YXRlGAIgASgO" + "Mi4uQVRQbGF0Zm9ybS5JREwuQWJ1c2VBbGVydC5BYnVzZUFsZXJ0U3RhdGVU" + "eXBlEhMKC2Fzc2lnbmVkX3RvGAMgASgFEhgKEGxhc3RfYWN0aW9uX2RhdGUY" + "BCABKAMSDwoHY29tbWVudBgFIAEoCSK6AQocQWJ1c2VBbGVydFN0YXRlZnVs" + "QWxlcnRQcm90bxJQCgphbGVydF9kYXRhGAEgASgLMjwuQVRQbGF0Zm9ybS5J" + "REwuQWJ1c2VBbGVydC5BYnVzZUFsZXJ0U3RhdGVsZXNzQWxlcnREYXRhUHJv" + "dG8SSAoLYWxlcnRfc3RhdGUYAiABKAsyMy5BVFBsYXRmb3JtLklETC5BYnVz" + "ZUFsZXJ0LkFidXNlQWxlcnRTdGF0ZURhdGFQcm90byKpAQoaQWxlcnRzRmls" + "dGVyZWRSZXF1ZXN0UHJvdG8SEQoJZGF0ZV9mcm9tGAEgASgDEg8KB2RhdGVf" + "dG8YAiABKAMSEwoLYWNjb3VudF9pZHMYAyADKAUSEgoKcnVsZV9jb2RlcxgE" + "IAMoBRI+CgZzdGF0ZXMYBSADKA4yLi5BVFBsYXRmb3JtLklETC5BYnVzZUFs" + "ZXJ0LkFidXNlQWxlcnRTdGF0ZVR5cGUijAEKJ0dldEFidXNlQWxlcnRTdGF0" + "ZWZ1bEFsZXJ0c1JlcXVlc3RQcm90bxIMCgRza2lwGAEgASgFEgwKBHRha2UY" + "AiABKAUSRQoGZmlsdGVyGAMgASgLMjUuQVRQbGF0Zm9ybS5JREwuQWJ1c2VB" + "bGVydC5BbGVydHNGaWx0ZXJlZFJlcXVlc3RQcm90byKiAQoiR2V0QWxlcnRz" + "RmlsdGVyZWRDb3VudFJlcXVlc3RQcm90bxI1Cg1jb3VudF9yZXF1ZXN0GAEg" + "ASgOMh4uQVRQbGF0Zm9ybS5JREwuQ291bnRUeXBlUHJvdG8SRQoGZmlsdGVy" + "GAIgASgLMjUuQVRQbGF0Zm9ybS5JREwuQWJ1c2VBbGVydC5BbGVydHNGaWx0" + "ZXJlZFJlcXVlc3RQcm90byJ3CixHZXRBYnVzZUFsZXJ0U3RhdGVmdWxBbGVy" + "dHNOb3RpZmljYXRpb25Qcm90bxJHCgZhbGVydHMYASADKAsyNy5BVFBsYXRm" + "b3JtLklETC5BYnVzZUFsZXJ0LkFidXNlQWxlcnRTdGF0ZWZ1bEFsZXJ0UHJv" + "dG8idQorQWJ1c2VBbGVydE5ld1N0YXRlZnVsQWxlcnROb3RpZmljYXRpb25Q" + "cm90bxJGCgVhbGVydBgBIAEoCzI3LkFUUGxhdGZvcm0uSURMLkFidXNlQWxl" + "cnQuQWJ1c2VBbGVydFN0YXRlZnVsQWxlcnRQcm90byJyCiZBYnVzZUFsZXJ0" + "VXBkYXRlQWxlcnRTdGF0ZVJlcXVlc3RQcm90bxJICgthbGVydF9zdGF0ZRgB" + "IAEoCzIzLkFUUGxhdGZvcm0uSURMLkFidXNlQWxlcnQuQWJ1c2VBbGVydFN0" + "YXRlRGF0YVByb3RvIncKK0FidXNlQWxlcnRVcGRhdGVBbGVydFN0YXRlTm90" + "aWZpY2F0aW9uUHJvdG8SSAoLYWxlcnRfc3RhdGUYASABKAsyMy5BVFBsYXRm" + "b3JtLklETC5BYnVzZUFsZXJ0LkFidXNlQWxlcnRTdGF0ZURhdGFQcm90byJj" + "CiJBYnVzZUFsZXJ0UnVsZVNldHRpbmdLZXlWYWx1ZVByb3RvEgsKA0tleRgB" + "IAEoCRINCgVWYWx1ZRgCIAEoCRIMCgRUeXBlGAMgASgJEhMKC0Rlc2NyaXB0" + "aW9uGAQgASgJIqABChtBYnVzZUFsZXJ0UnVsZVNldHRpbmdzUHJvdG8SEQoJ" + "cnVsZV9jb2RlGAEgASgFEhEKCXJ1bGVfbmFtZRgCIAEoCRJbChRydWxlX3Nl" + "dHRpbmdzX2ZpZWxkcxgDIAMoCzI9LkFUUGxhdGZvcm0uSURMLkFidXNlQWxl" + "cnQuQWJ1c2VBbGVydFJ1bGVTZXR0aW5nS2V5VmFsdWVQcm90byIoCiZHZXRB" + "YnVzZUFsZXJ0UnVsZXNTZXR0aW5nc1JlcXVlc3RQcm90byKBAQorR2V0QWJ1" + "c2VBbGVydFJ1bGVzU2V0dGluZ3NOb3RpZmljYXRpb25Qcm90bxJSChJhbGxf" + "cnVsZXNfc2V0dGluZ3MYASADKAsyNi5BVFBsYXRmb3JtLklETC5BYnVzZUFs" + "ZXJ0LkFidXNlQWxlcnRSdWxlU2V0dGluZ3NQcm90byJ5CihBYnVzZUFsZXJ0" + "VXBkYXRlUnVsZVNldHRpbmdzUmVxdWVzdFByb3RvEk0KDXJ1bGVfc2V0dGlu" + "Z3MYASABKAsyNi5BVFBsYXRmb3JtLklETC5BYnVzZUFsZXJ0LkFidXNlQWxl" + "cnRSdWxlU2V0dGluZ3NQcm90byJ+Ci1BYnVzZUFsZXJ0VXBkYXRlUnVsZVNl" + "dHRpbmdzTm90aWZpY2F0aW9uUHJvdG8STQoNcnVsZV9zZXR0aW5ncxgBIAEo" + "CzI2LkFUUGxhdGZvcm0uSURMLkFidXNlQWxlcnQuQWJ1c2VBbGVydFJ1bGVT" + "ZXR0aW5nc1Byb3RvKoICChJBYnVzZUFsZXJ0UnVsZUNvZGUSEgoOVU5ERUZJ" + "TkVEX1JVTEUQABIgChxDTElFTlRfU0VTU0lPTlNfRlJPTV9TQU1FX0lQEAES" + "FAoQRElTQUJMRURfQUNDT1VOVBACEhMKD01BUkdJTl9FWFBPU1VSRRADEhIK" + "DlNDQUxQRVJfT1JERVJTEAQSHAoYRVFVSVRZX0lOQ1JFQVNFX0lOX0FfREFZ" + "EAUSEwoPT1BQT1NJVEVfT1JERVJTEAYSFAoQQUxMX0lOX0JFSEFWSU9VUhAH" + "EhkKFUZSRVFVRU5UX09SREVSX1RSQURFUxAIEhMKD0JMQUNLTElTVEVEX0lQ" + "UxAJKmwKE0FidXNlQWxlcnRTdGF0ZVR5cGUSEwoPVU5ERUZJTkVEX1NUQVRF" + "EAASBwoDTkVXEAESDQoJSU5fUkVWSUVXEAISDAoIRVNDQUxBVEUQAxINCglD" + "T01QTEVURUQQBBILCgdFWFBJUkVEEAVCIUgB+AEBqgIZQVRQbGF0Zm9ybS5J" + "REwuQWJ1c2VBbGVydGIGcHJvdG8z"), new FileDescriptor[1]
    {
      ATPlatformCommonReflection.Descriptor
    }, new GeneratedClrTypeInfo(new System.Type[2]
    {
      typeof (AbuseAlertRuleCode),
      typeof (AbuseAlertStateType)
    }, new GeneratedClrTypeInfo[16]
    {
      new GeneratedClrTypeInfo(typeof (AbuseAlertStatelessAlertDataProto), (MessageParser) AbuseAlertStatelessAlertDataProto.Parser, new string[12]
      {
        "Id",
        "RuleCode",
        "RuleName",
        "AccountId",
        "AlertKey",
        "Timestamp",
        "DataSnapshot",
        "SettingsSnapshot",
        "AdditionalData",
        "AccountName",
        "AccountTradeSettings",
        "AccountHedgeSettings"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertStateDataProto), (MessageParser) AbuseAlertStateDataProto.Parser, new string[5]
      {
        "AlertId",
        "State",
        "AssignedTo",
        "LastActionDate",
        "Comment"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertStatefulAlertProto), (MessageParser) AbuseAlertStatefulAlertProto.Parser, new string[2]
      {
        "AlertData",
        "AlertState"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AlertsFilteredRequestProto), (MessageParser) AlertsFilteredRequestProto.Parser, new string[5]
      {
        "DateFrom",
        "DateTo",
        "AccountIds",
        "RuleCodes",
        "States"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetAbuseAlertStatefulAlertsRequestProto), (MessageParser) GetAbuseAlertStatefulAlertsRequestProto.Parser, new string[3]
      {
        "Skip",
        "Take",
        "Filter"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetAlertsFilteredCountRequestProto), (MessageParser) GetAlertsFilteredCountRequestProto.Parser, new string[2]
      {
        "CountRequest",
        "Filter"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetAbuseAlertStatefulAlertsNotificationProto), (MessageParser) GetAbuseAlertStatefulAlertsNotificationProto.Parser, new string[1]
      {
        "Alerts"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertNewStatefulAlertNotificationProto), (MessageParser) AbuseAlertNewStatefulAlertNotificationProto.Parser, new string[1]
      {
        "Alert"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertUpdateAlertStateRequestProto), (MessageParser) AbuseAlertUpdateAlertStateRequestProto.Parser, new string[1]
      {
        "AlertState"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertUpdateAlertStateNotificationProto), (MessageParser) AbuseAlertUpdateAlertStateNotificationProto.Parser, new string[1]
      {
        "AlertState"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertRuleSettingKeyValueProto), (MessageParser) AbuseAlertRuleSettingKeyValueProto.Parser, new string[4]
      {
        "Key",
        "Value",
        "Type",
        "Description"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertRuleSettingsProto), (MessageParser) AbuseAlertRuleSettingsProto.Parser, new string[3]
      {
        "RuleCode",
        "RuleName",
        "RuleSettingsFields"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetAbuseAlertRulesSettingsRequestProto), (MessageParser) GetAbuseAlertRulesSettingsRequestProto.Parser, (string[]) null, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (GetAbuseAlertRulesSettingsNotificationProto), (MessageParser) GetAbuseAlertRulesSettingsNotificationProto.Parser, new string[1]
      {
        "AllRulesSettings"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertUpdateRuleSettingsRequestProto), (MessageParser) AbuseAlertUpdateRuleSettingsRequestProto.Parser, new string[1]
      {
        "RuleSettings"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null),
      new GeneratedClrTypeInfo(typeof (AbuseAlertUpdateRuleSettingsNotificationProto), (MessageParser) AbuseAlertUpdateRuleSettingsNotificationProto.Parser, new string[1]
      {
        "RuleSettings"
      }, (string[]) null, (System.Type[]) null, (GeneratedClrTypeInfo[]) null)
    }));

    public static FileDescriptor Descriptor => ATPlatformAbuseAlertReflection.descriptor;
  }
}
