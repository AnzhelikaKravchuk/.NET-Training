<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// Task is in System.Threading.Tasks
Task.Run(() =>
{
	Console.WriteLine("Hello from the thread pool");
	Thread.CurrentThread.GetHashCode().Dump();
});

// The old-school way:
ThreadPool.QueueUserWorkItem(notUsed =>
{
	Console.WriteLine("Hello, old-school");
	Thread.CurrentThread.GetHashCode().Dump();
});

// The old-school way:
ThreadPool.QueueUserWorkItem(notUsed =>
{
	Console.WriteLine("Hello, old-school 1");
	Thread.CurrentThread.GetHashCode().Dump();
});