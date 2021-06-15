// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.LSStreamReader
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

using System.IO;
using System.Text;

namespace Lightstreamer.DotNet.Client
{
  public class LSStreamReader : StreamReader
  {
    public LSStreamReader(Stream baseStream, Encoding encoding)
      : base(baseStream, encoding)
    {
    }

    public new virtual void Close() => this.Dispose();
  }
}
