<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	//Hence our method returns a task that completes five seconds later,
	//with a result of 42. By attaching a continuation to the task, 
	//we can write its result without any blocking any thread
	var awaiter = GetAnswerToLife().GetAwaiter();
	awaiter.OnCompleted (() => Console.WriteLine (awaiter.GetResult()));
}
//The real power of TaskCompletionSource is in creating tasks
//that don’t tie up threads
Task<int> GetAnswerToLife()
{
	var tcs = new TaskCompletionSource<int>();
	// Create a timer that fires once in 5000 ms:
	var timer = new System.Timers.Timer (5000) { AutoReset = false };
	timer.Elapsed += delegate { timer.Dispose(); tcs.SetResult (42); };
	timer.Start();
	return tcs.Task;
}