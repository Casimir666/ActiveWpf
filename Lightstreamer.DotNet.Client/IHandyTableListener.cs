// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.IHandyTableListener
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

namespace Lightstreamer.DotNet.Client
{
  public interface IHandyTableListener
  {
    void OnUpdate(int itemPos, string itemName, IUpdateInfo update);

    void OnSnapshotEnd(int itemPos, string itemName);

    void OnRawUpdatesLost(int itemPos, string itemName, int lostUpdates);

    void OnUnsubscr(int itemPos, string itemName);

    void OnUnsubscrAll();
  }
}
