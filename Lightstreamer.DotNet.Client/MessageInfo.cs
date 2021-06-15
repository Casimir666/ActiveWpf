// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.MessageInfo
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

using System;
using System.Text.RegularExpressions;

namespace Lightstreamer.DotNet.Client
{
  public class MessageInfo
  {
    public const string UNORDERED_MESSAGES = "UNORDERED_MESSAGES";
    private int delayTimeout = -1;
    private string sequence;
    private string message;
    private const string wrongSeqName = "Sequence name can only contain alphanumeric characters and/or underscores and can't be null nor an empry string";
    private const string noMessage = "Message cannot be null";
    private static Regex ext_alpha_numeric = new Regex("^[a-zA-Z0-9_]*$");

    public MessageInfo(string message, string sequence)
      : this(message, sequence, -1)
    {
    }

    public MessageInfo(string message, string sequence, int delayTimeout)
    {
      this.message = message != null ? message : throw new ArgumentException("Message cannot be null");
      this.sequence = sequence;
      this.delayTimeout = delayTimeout;
    }

    public override string ToString() => this.sequence + "/" + (object) this.delayTimeout + "/" + this.message;

    public int DelayTimeout => this.delayTimeout;

    public string Sequence
    {
      get => this.sequence;
      private set
      {
        switch (value)
        {
          case "":
          case null:
            throw new ArgumentException("Sequence name can only contain alphanumeric characters and/or underscores and can't be null nor an empry string");
          default:
            if (MessageInfo.ext_alpha_numeric.IsMatch(this.sequence))
              break;
            throw new ArgumentException("Sequence name can only contain alphanumeric characters and/or underscores and can't be null nor an empry string");
        }
      }
    }

    public string Message => this.message;
  }
}
