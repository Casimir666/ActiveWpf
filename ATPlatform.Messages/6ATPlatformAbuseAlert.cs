﻿// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.AbuseAlert.GetAlertsFilteredCountRequestProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL.AbuseAlert
{
  public sealed class GetAlertsFilteredCountRequestProto : 
    IMessage<GetAlertsFilteredCountRequestProto>,
    IMessage,
    IEquatable<GetAlertsFilteredCountRequestProto>,
    IDeepCloneable<GetAlertsFilteredCountRequestProto>,
    IGetCount
  {
    private static readonly MessageParser<GetAlertsFilteredCountRequestProto> _parser = new MessageParser<GetAlertsFilteredCountRequestProto>((Func<GetAlertsFilteredCountRequestProto>) (() => new GetAlertsFilteredCountRequestProto()));
    private UnknownFieldSet _unknownFields;
    public const int CountRequestFieldNumber = 1;
    private CountTypeProto countRequest_;
    public const int FilterFieldNumber = 2;
    private AlertsFilteredRequestProto filter_;

    [DebuggerNonUserCode]
    public static MessageParser<GetAlertsFilteredCountRequestProto> Parser => GetAlertsFilteredCountRequestProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformAbuseAlertReflection.Descriptor.MessageTypes[5];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => GetAlertsFilteredCountRequestProto.Descriptor;

    [DebuggerNonUserCode]
    public GetAlertsFilteredCountRequestProto()
    {
    }

    [DebuggerNonUserCode]
    public GetAlertsFilteredCountRequestProto(GetAlertsFilteredCountRequestProto other)
      : this()
    {
      this.countRequest_ = other.countRequest_;
      this.filter_ = other.filter_ != null ? other.filter_.Clone() : (AlertsFilteredRequestProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public GetAlertsFilteredCountRequestProto Clone() => new GetAlertsFilteredCountRequestProto(this);

    [DebuggerNonUserCode]
    public CountTypeProto CountRequest
    {
      get => this.countRequest_;
      set => this.countRequest_ = value;
    }

    [DebuggerNonUserCode]
    public AlertsFilteredRequestProto Filter
    {
      get => this.filter_;
      set => this.filter_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as GetAlertsFilteredCountRequestProto);

    [DebuggerNonUserCode]
    public bool Equals(GetAlertsFilteredCountRequestProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return this.CountRequest == other.CountRequest && object.Equals((object) this.Filter, (object) other.Filter) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.CountRequest != CountTypeProto.UndefinedCountRequest)
        num ^= this.CountRequest.GetHashCode();
      if (this.filter_ != null)
        num ^= this.Filter.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.CountRequest != CountTypeProto.UndefinedCountRequest)
      {
        output.WriteRawTag((byte) 8);
        output.WriteEnum((int) this.CountRequest);
      }
      if (this.filter_ != null)
      {
        output.WriteRawTag((byte) 18);
        output.WriteMessage((IMessage) this.Filter);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.CountRequest != CountTypeProto.UndefinedCountRequest)
        num += 1 + CodedOutputStream.ComputeEnumSize((int) this.CountRequest);
      if (this.filter_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.Filter);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(GetAlertsFilteredCountRequestProto other)
    {
      if (other == null)
        return;
      if (other.CountRequest != CountTypeProto.UndefinedCountRequest)
        this.CountRequest = other.CountRequest;
      if (other.filter_ != null)
      {
        if (this.filter_ == null)
          this.Filter = new AlertsFilteredRequestProto();
        this.Filter.MergeFrom(other.Filter);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        switch (num)
        {
          case 8:
            this.CountRequest = (CountTypeProto) input.ReadEnum();
            continue;
          case 18:
            if (this.filter_ == null)
              this.Filter = new AlertsFilteredRequestProto();
            input.ReadMessage((IMessage) this.Filter);
            continue;
          default:
            this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
            continue;
        }
      }
    }
  }
}
