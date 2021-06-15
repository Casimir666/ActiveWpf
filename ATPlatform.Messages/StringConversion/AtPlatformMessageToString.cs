// Decompiled with JetBrains decompiler
// Type: ATPlatform.Messages.StringConversion.AtPlatformMessageToString
// Assembly: ATPlatform.Messages, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 6651AE18-E9AC-4965-9D78-DF9CC6E22F42
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Messages.dll

using ATPlatform.IDL;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Collections.Generic;

namespace ATPlatform.Messages.StringConversion
{
  public class AtPlatformMessageToString
  {
    private static readonly HashSet<MessageTypeProto> _supportedMessageTypes = MessagesDescriptors.SupportedMessageTypes;
    private static readonly Dictionary<MessageTypeProto, MessageDescriptor> _supportedMessagesDescriptors = MessagesDescriptors.SupportedMessagesDescriptors;
    private static readonly JsonFormatter jsonFormatter;
    private static readonly JsonFormatter JsonFormatter = new JsonFormatter(JsonFormatter.Settings.Default);

    static AtPlatformMessageToString() => AtPlatformMessageToString.jsonFormatter = new JsonFormatter(new JsonFormatter.Settings(false));

    public static string MessageProtoToString(
      MessageTypeProto messageTypeProto,
      byte[] receiveMessagePayload,
      AtPlatformMessageToString.MessageProtoStringFormat stringFormat)
    {
      string str = string.Empty;
      MessageDescriptor messageDescriptor;
      if (AtPlatformMessageToString._supportedMessagesDescriptors.TryGetValue(messageTypeProto, out messageDescriptor))
      {
        if (messageDescriptor != null)
        {
          if (stringFormat != AtPlatformMessageToString.MessageProtoStringFormat.JSON)
          {
            if (stringFormat != AtPlatformMessageToString.MessageProtoStringFormat.Text)
              throw new NotSupportedException(string.Format("{0} of type {1} with value {2} is not supported.", (object) nameof (stringFormat), (object) stringFormat.GetType().Name, (object) stringFormat));
            str = messageDescriptor.Parser.ParseFrom(receiveMessagePayload).ToString();
          }
          else
          {
            IMessage from = messageDescriptor.Parser.ParseFrom(receiveMessagePayload);
            str = AtPlatformMessageToString.jsonFormatter.Format(from);
          }
        }
      }
      else
        str = string.Format("'{0}' not supported.", (object) messageTypeProto);
      return str;
    }

    public static string ATServerMessageToString(
      MessageTypeProto requestTypeProto,
      byte[] receiveMessagePayload)
    {
      MessageDescriptor messageDescriptor;
      return AtPlatformMessageToString._supportedMessagesDescriptors.TryGetValue(requestTypeProto, out messageDescriptor) ? messageDescriptor.Parser.ParseFrom(receiveMessagePayload).ToString() : "Message not recognized";
    }

    public static string ATServerMessageToJson(
      MessageTypeProto requestTypeProto,
      byte[] receiveMessagePayload)
    {
      MessageDescriptor messageDescriptor;
      if (!AtPlatformMessageToString._supportedMessagesDescriptors.TryGetValue(requestTypeProto, out messageDescriptor))
        return (string) null;
      IMessage from = messageDescriptor.Parser.ParseFrom(receiveMessagePayload);
      return AtPlatformMessageToString.JsonFormatter.Format(from);
    }

    public static IMessage ATServerMessageFromJson(
      MessageTypeProto requestTypeProto,
      string messageAsString)
    {
      MessageDescriptor messageDescriptor;
      return AtPlatformMessageToString._supportedMessagesDescriptors.TryGetValue(requestTypeProto, out messageDescriptor) ? messageDescriptor.Parser.ParseJson(messageAsString) : (IMessage) null;
    }

    public enum MessageProtoStringFormat
    {
      Undefined,
      JSON,
      Text,
    }
  }
}
