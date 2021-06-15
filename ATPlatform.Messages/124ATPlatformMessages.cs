// Decompiled with JetBrains decompiler
// Type: ATPlatform.IDL.SymbolGroupNotificationProto
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace ATPlatform.IDL
{
  public sealed class SymbolGroupNotificationProto : 
    IMessage<SymbolGroupNotificationProto>,
    IMessage,
    IEquatable<SymbolGroupNotificationProto>,
    IDeepCloneable<SymbolGroupNotificationProto>
  {
    private static readonly MessageParser<SymbolGroupNotificationProto> _parser = new MessageParser<SymbolGroupNotificationProto>((Func<SymbolGroupNotificationProto>) (() => new SymbolGroupNotificationProto()));
    private UnknownFieldSet _unknownFields;
    public const int SymbolGroupFieldNumber = 1;
    private SymbolGroupProto symbolGroup_;

    [DebuggerNonUserCode]
    public static MessageParser<SymbolGroupNotificationProto> Parser => SymbolGroupNotificationProto._parser;

    [DebuggerNonUserCode]
    public static MessageDescriptor Descriptor => ATPlatformMessagesReflection.Descriptor.MessageTypes[117];

    [DebuggerNonUserCode]
    MessageDescriptor IMessage.Descriptor => SymbolGroupNotificationProto.Descriptor;

    [DebuggerNonUserCode]
    public SymbolGroupNotificationProto()
    {
    }

    [DebuggerNonUserCode]
    public SymbolGroupNotificationProto(SymbolGroupNotificationProto other)
      : this()
    {
      this.symbolGroup_ = other.symbolGroup_ != null ? other.symbolGroup_.Clone() : (SymbolGroupProto) null;
      this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
    }

    [DebuggerNonUserCode]
    public SymbolGroupNotificationProto Clone() => new SymbolGroupNotificationProto(this);

    [DebuggerNonUserCode]
    public SymbolGroupProto SymbolGroup
    {
      get => this.symbolGroup_;
      set => this.symbolGroup_ = value;
    }

    [DebuggerNonUserCode]
    public override bool Equals(object other) => this.Equals(other as SymbolGroupNotificationProto);

    [DebuggerNonUserCode]
    public bool Equals(SymbolGroupNotificationProto other)
    {
      if (other == null)
        return false;
      if (other == this)
        return true;
      return object.Equals((object) this.SymbolGroup, (object) other.SymbolGroup) && object.Equals((object) this._unknownFields, (object) other._unknownFields);
    }

    [DebuggerNonUserCode]
    public override int GetHashCode()
    {
      int num = 1;
      if (this.symbolGroup_ != null)
        num ^= this.SymbolGroup.GetHashCode();
      if (this._unknownFields != null)
        num ^= this._unknownFields.GetHashCode();
      return num;
    }

    [DebuggerNonUserCode]
    public override string ToString() => JsonFormatter.ToDiagnosticString((IMessage) this);

    [DebuggerNonUserCode]
    public void WriteTo(CodedOutputStream output)
    {
      if (this.symbolGroup_ != null)
      {
        output.WriteRawTag((byte) 10);
        output.WriteMessage((IMessage) this.SymbolGroup);
      }
      if (this._unknownFields == null)
        return;
      this._unknownFields.WriteTo(output);
    }

    [DebuggerNonUserCode]
    public int CalculateSize()
    {
      int num = 0;
      if (this.symbolGroup_ != null)
        num += 1 + CodedOutputStream.ComputeMessageSize((IMessage) this.SymbolGroup);
      if (this._unknownFields != null)
        num += this._unknownFields.CalculateSize();
      return num;
    }

    [DebuggerNonUserCode]
    public void MergeFrom(SymbolGroupNotificationProto other)
    {
      if (other == null)
        return;
      if (other.symbolGroup_ != null)
      {
        if (this.symbolGroup_ == null)
          this.SymbolGroup = new SymbolGroupProto();
        this.SymbolGroup.MergeFrom(other.SymbolGroup);
      }
      this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
    }

    [DebuggerNonUserCode]
    public void MergeFrom(CodedInputStream input)
    {
      uint num;
      while ((num = input.ReadTag()) != 0U)
      {
        if (num != 10U)
        {
          this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, input);
        }
        else
        {
          if (this.symbolGroup_ == null)
            this.SymbolGroup = new SymbolGroupProto();
          input.ReadMessage((IMessage) this.SymbolGroup);
        }
      }
    }
  }
}
