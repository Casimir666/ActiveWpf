// Decompiled with JetBrains decompiler
// Type: Lightstreamer.DotNet.Client.ThreadSupport
// Assembly: Lightstreamer_DotNet_PCL_Client, Version=3.1.6640.22649, Culture=neutral, PublicKeyToken=null
// MVID: 34D227FF-FB77-472F-96EF-5762687E571A
// Assembly location: C:\Users\c.esneault\source\repos\TestA\TestA\bin\Debug\net5.0\Lightstreamer_DotNet_PCL_Client.dll

using System;
using System.Threading.Tasks;

namespace Lightstreamer.DotNet.Client
{
  internal class ThreadSupport : IThreadRunnable
  {
    private Task threadField;
    public string Name;

    public ThreadSupport()
    {
      this.threadField = new Task(new Action(this.Run));
      this.Name = this.threadField.Id.ToString();
    }

    public ThreadSupport(string Name)
    {
      this.threadField = new Task(new Action(this.Run));
      this.Name = Name;
    }

    public virtual void Run()
    {
    }

    public virtual void Start(bool isBackground) => this.threadField.Start();

    public void Abort()
    {
    }

    public override string ToString() => "Thread[" + this.Name + "," + "]";
  }
}
