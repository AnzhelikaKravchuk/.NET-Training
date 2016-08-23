<Query Kind="Program" />

public class ActionQueue<T> : IDisposable where T : class
{
	private readonly Action<T> _action;
	private readonly Queue<T> _queue;
	private readonly Thread _thread;
	private readonly EventWaitHandle _waitHandle;

	public ActionQueue(Action<T> action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		_action = action;
		_queue = new Queue<T>();
		_thread = new Thread(MainLoop) {IsBackground = true};
		_waitHandle = new AutoResetEvent(false);
		_thread.Start();
	}

	public void Dispose()
	{
		_waitHandle.Close();
	}

	public void EnqueueElement(T element)
	{
		lock (_queue)
		{
			_queue.Enqueue(element);
		}
		_waitHandle.Set();
	}

	public void Stop()
	{
		EnqueueElement(null);
		_thread.Join();
		_waitHandle.Reset();
	}

	private void MainLoop()
	{
		while (true)
		{
			T element = null;
			lock (_queue)
			{
				if (_queue.Count > 0)
				{
					element = _queue.Dequeue();
					if (element == null)
					{
						return;
					}
				}
			}
			if (element != null)
			{
				_action(element);
			}
			else
			{
				_waitHandle.WaitOne();
			}
		}
	}
}
