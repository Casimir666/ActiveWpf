// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.IConnectionListener
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

namespace Lightstreamer.DotNet.Client
{
  public interface IConnectionListener
  {
    void OnConnectionEstablished();

    void OnSessionStarted(bool isPolling);

    void OnNewBytes(long bytes);

    void OnDataError(PushServerException e);

    void OnActivityWarning(bool warningOn);

    void OnClose();

    void OnEnd(int cause);

    void OnFailure(PushServerException e);

    void OnFailure(PushConnException e);
  }
}
