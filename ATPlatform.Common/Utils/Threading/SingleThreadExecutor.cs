// Decompiled with JetBrains decompiler
// Type: ATPlatform.Common.Utils.Threading.SingleThreadExecutor
// Assembly: ATPlatform.Common, Version=3.20.0.0, Culture=neutral, PublicKeyToken=5c835f9b5b0ff0ca
// MVID: 8510DEE7-1F48-4C8D-BDF8-D15D1FBC6558
// Assembly location: C:\Users\c.esneault\source\repos\TestA2\TestA2\bin\Debug\ATPlatform.Common.dll

using ATPlatform.Common.Utils.Logging;
using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ATPlatform.Common.Utils.Threading
{
  public class SingleThreadExecutor : ITaskExecutor, IDisposable
  {
    private static readonly TimeSpan _nextTaskTimeout = TimeSpan.FromMilliseconds(100.0);
    private readonly ILogger _looger = LoggerFactory.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
    private bool disposed;
    private bool isStarted;
    private readonly object startLock = new object();
    private readonly ConcurrentQueue<Action> tasks = new ConcurrentQueue<Action>();
    private CancellationTokenSource stopTokenSource;
    private readonly AutoResetEvent taskAdded = new AutoResetEvent(false);

    public SingleThreadExecutor() => this.Name = this.BuildName((string) null);

    public SingleThreadExecutor(string externalId) => this.Name = this.BuildName(externalId);

    public string Name { get; }

    public void EnqueueTask(Action task)
    {
      if (!this.isStarted)
      {
        lock (this.startLock)
        {
          if (!this.isStarted)
          {
            this.Start();
            this.isStarted = true;
          }
        }
      }
      this.tasks.Enqueue(task);
      this.taskAdded.Set();
    }

    private void Start()
    {
      this.stopTokenSource?.Cancel();
      this.stopTokenSource = new CancellationTokenSource();
      Task.Factory.StartNew((Action) (() => this.DoStart(this.stopTokenSource.Token)), this.stopTokenSource.Token, TaskCreationOptions.LongRunning, TaskScheduler.Current);
      this._looger.WarnFormat("Executor {0} started", (object) this.Name);
    }

    private void DoStart(CancellationToken stopToken)
    {
      try
      {
        Thread.CurrentThread.Name = this.Name;
        this.ProcessTasks(stopToken);
      }
      catch (Exception ex)
      {
        this._looger.Error((object) ("Task processing failed. Executor ID " + this.Name + " stopped. Error:" + ex.Message), ex);
      }
    }

    private void ProcessTasks(CancellationToken stopToken)
    {
      while (!stopToken.IsCancellationRequested)
      {
        Action result;
        while (!stopToken.IsCancellationRequested && this.tasks.TryDequeue(out result))
          this.ExecuteTask(result);
        this.taskAdded.WaitOne(SingleThreadExecutor._nextTaskTimeout);
      }
    }

    public void Dispose()
    {
      if (this.disposed)
        return;
      if (this.stopTokenSource != null)
      {
        this.stopTokenSource.Cancel();
        this.taskAdded.Set();
        this.stopTokenSource.Dispose();
        this.stopTokenSource = (CancellationTokenSource) null;
      }
      this.taskAdded.Dispose();
      this.disposed = true;
    }

    protected void ExecuteTask(Action task)
    {
      try
      {
        task();
      }
      catch (Exception ex)
      {
        this._looger.Error((object) ("Task execution failed. Executor ID " + this.Name + ". Error:" + ex.Message), ex);
      }
    }

    private string BuildName(string externalId) => string.Format("{0}-{1}{2}", (object) MethodBase.GetCurrentMethod().DeclaringType?.Name, string.IsNullOrEmpty(externalId) ? (object) string.Empty : (object) (externalId + "-"), (object) new Random((int) DateTime.Now.Ticks).Next(0, int.MaxValue));
  }
}
