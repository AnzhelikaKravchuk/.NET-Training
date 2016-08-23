<Query Kind="Program" />

static void Main()
{
	Thread t = new Thread (WriteY); 
	t.Name = "Thread 111";// Kick off a new thread
	t.Start();                               // running WriteY()

	// Simultaneously, do something on the main thread.
	for (int i = 0; i < 1000; i++) Console.Write ("x");
}

static void WriteY()
{
	Thread.CurrentThread.ThreadState.Dump();
	Thread.CurrentThread.GetHashCode().Dump();
	for (int i = 0; i < 1000; i++) Console.Write ("y");
}