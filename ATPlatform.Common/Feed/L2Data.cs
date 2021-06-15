// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Feed.L2Data
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using System;
using System.Linq;
using System.Text;

namespace ATPlatform.Common.Feed
{
  public struct L2Data
  {
    private const byte DefaultProviderID = 0;
    private const byte levelsMaxArraySize = 5;
    private string symbolId;
    private byte providerID;
    private byte digits;
    private byte tickType;
    private long timestamp;
    private uint sequenceNumber;
    private const int symLen = 12;
    private const int reserverd = 1;

    public void Deserialize(byte[] buffer)
    {
      int index1 = 0;
      this.symbolId = Encoding.ASCII.GetString(buffer, index1, 12);
      this.symbolId = this.symbolId.TrimEnd(new char[1]);
      int index2 = index1 + 12;
      this.providerID = buffer[index2];
      int index3 = index2 + 1;
      this.digits = buffer[index3];
      int index4 = index3 + 1;
      this.tickType = buffer[index4];
      int startIndex1 = index4 + 1 + 1;
      if (this.Levels == null)
        this.Levels = new L2PriceModel[5];
      for (int index5 = 0; index5 < 5; ++index5)
      {
        L2PriceModel l2PriceModel = new L2PriceModel();
        l2PriceModel.Price = (double) BitConverter.ToInt32(buffer, startIndex1) / Math.Pow(10.0, (double) this.digits);
        int startIndex2 = startIndex1 + 4;
        l2PriceModel.Volume = (double) BitConverter.ToInt32(buffer, startIndex2);
        startIndex1 = startIndex2 + 4;
        this.Levels[index5] = l2PriceModel;
      }
      this.timestamp = BitConverter.ToInt64(buffer, startIndex1);
      int startIndex3 = startIndex1 + 8;
      this.sequenceNumber = BitConverter.ToUInt32(buffer, startIndex3);
      int num = startIndex3 + 4;
    }

    public string SymbolId
    {
      get => this.symbolId;
      set => this.symbolId = value;
    }

    public byte ProviderID
    {
      get => this.providerID;
      set => this.providerID = value;
    }

    public byte Digits
    {
      get => this.digits;
      set => this.digits = value;
    }

    public byte TickType
    {
      get => this.tickType;
      set => this.tickType = value;
    }

    public long Timestamp
    {
      get => this.timestamp;
      set => this.timestamp = value;
    }

    public uint SequenceNumber
    {
      get => this.sequenceNumber;
      set => this.sequenceNumber = value;
    }

    public string ProviderName
    {
      get
      {
        Constants.PriceProviderNames.Count<string>();
        return Constants.PriceProviderNames[0];
      }
    }

    public L2PriceModel[] Levels { get; set; }
  }
}
