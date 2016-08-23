<Query Kind="Program" />

//static AutoResetEvent re = null; 
	static ManualResetEvent re = null;

	static void Worker()
	{
		re.WaitOne();
		Console.WriteLine("Поток {0} получил событие", Thread.CurrentThread.Name);
	}

	static void Main()
	{
		re = new ManualResetEvent(false);
		Thread threadA = new Thread(Worker) { Name = "A" };
		Thread threadB = new Thread(Worker) { Name = "B" };
		Thread threadC = new Thread(Worker) { Name = "C" };
		threadA.Start();
		threadB.Start();
		threadC.Start();
		Console.WriteLine("Потоки запущены");
		Thread.Sleep(4000);
		re.Set();
	}