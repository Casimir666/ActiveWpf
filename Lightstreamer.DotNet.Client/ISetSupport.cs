// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.ISetSupport
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

using System.Collections;

namespace Lightstreamer.DotNet.Client
{
  internal interface ISetSupport : ICollection, IEnumerable, IList
  {
    bool Add(object obj);

    bool AddAll(ICollection c);
  }
}
