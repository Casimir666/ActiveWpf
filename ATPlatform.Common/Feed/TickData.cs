// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Feed.TickData
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;
using System.Text;

namespace ATPlatform.Common.Feed
{
  public struct TickData : ITick
  {
    public const byte DefaultProviderID = 0;
    private string symbolId;
    private int bidPips;
    private int askPips;
    private byte digits;
    private ushort sequenceNumber;
    private byte providerID;
    private long timestamp;

    public byte[] Serialize()
    {
      byte[] numArray = new byte[32];
      byte[] bytes1 = Encoding.ASCII.GetBytes(this.SymbolId);
      Array.Copy((Array) bytes1, 0, (Array) numArray, 0, bytes1.Length);
      numArray[12] = this.providerID;
      numArray[13] = this.digits;
      byte[] bytes2 = BitConverter.GetBytes(this.SequenceNumber);
      Array.Copy((Array) bytes2, 0, (Array) numArray, 14, bytes2.Length);
      byte[] bytes3 = BitConverter.GetBytes(this.Timestamp);
      Array.Copy((Array) bytes3, 0, (Array) numArray, 16, bytes3.Length);
      byte[] bytes4 = BitConverter.GetBytes(this.AskPips);
      Array.Copy((Array) bytes4, 0, (Array) numArray, 24, bytes4.Length);
      byte[] bytes5 = BitConverter.GetBytes(this.BidPips);
      Array.Copy((Array) bytes5, 0, (Array) numArray, 28, bytes5.Length);
      return numArray;
    }

    public void Deserialize(byte[] buffer)
    {
      int index1 = 0;
      this.symbolId = Encoding.ASCII.GetString(buffer, index1, 12);
      this.symbolId = this.symbolId.TrimEnd(new char[1]);
      int index2 = index1 + 12;
      this.providerID = buffer[index2];
      int index3 = index2 + 1;
      this.digits = buffer[index3];
      int startIndex1 = index3 + 1;
      this.sequenceNumber = BitConverter.ToUInt16(buffer, startIndex1);
      int startIndex2 = startIndex1 + 2;
      this.timestamp = BitConverter.ToInt64(buffer, startIndex2);
      int startIndex3 = startIndex2 + 8;
      this.askPips = BitConverter.ToInt32(buffer, startIndex3);
      int startIndex4 = startIndex3 + 4;
      this.bidPips = BitConverter.ToInt32(buffer, startIndex4);
      if ((int) this.providerID <= Constants.PriceProviderNames.Count)
        return;
      this.providerID = (byte) 0;
    }

    public double Bid => (double) this.bidPips / Math.Pow(10.0, (double) this.digits);

    public double Ask => (double) this.askPips / Math.Pow(10.0, (double) this.digits);

    public int SpreadPips => this.askPips - this.bidPips;

    public TickData(string symbolId, int bidPips, int askPips, byte digits)
      : this(symbolId, bidPips, askPips, digits, (ushort) 0, (byte) 0, 0L)
    {
    }

    public TickData(
      string symbolId,
      int bidPips,
      int askPips,
      byte digits,
      ushort sequenceNumber,
      byte providerID,
      long timestamp)
    {
      this.symbolId = symbolId;
      this.bidPips = bidPips;
      this.askPips = askPips;
      this.digits = digits;
      this.sequenceNumber = sequenceNumber;
      this.providerID = providerID;
      this.timestamp = timestamp;
    }

    public string SymbolId
    {
      get => this.symbolId;
      set => this.symbolId = value;
    }

    public int BidPips
    {
      get => this.bidPips;
      set => this.bidPips = value;
    }

    public int AskPips
    {
      get => this.askPips;
      set => this.askPips = value;
    }

    public byte Digits
    {
      get => this.digits;
      set => this.digits = value;
    }

    public ushort SequenceNumber
    {
      get => this.sequenceNumber;
      set => this.sequenceNumber = value;
    }

    public byte ProviderID
    {
      get => this.providerID;
      set => this.providerID = value;
    }

    public long Timestamp
    {
      get => this.timestamp;
      set => this.timestamp = value;
    }

    public void UpdateTickDigits(byte symbolDigits) => this.digits = symbolDigits;
  }
}
