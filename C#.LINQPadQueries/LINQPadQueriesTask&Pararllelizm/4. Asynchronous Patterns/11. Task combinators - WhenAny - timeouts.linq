<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//удобен при применении тайм-аутов или отмены к операциям,
//которые это не поддерживают
async void Main()
{
	Task<string> task = SomeAsyncFunc();
	Task winner = await (Task.WhenAny (task, Task.Delay(5000)));
	//because in this case we’re calling WhenAny with differently 
	//typed tasks,the winner is reported as a plain Task 
	//(rather than a Task<string>).
	if (winner != task) throw new TimeoutException();
	string result = await task;   // Unwrap result/re-throw
	Console.WriteLine(result);
}

async Task<string> SomeAsyncFunc()
{
	await Task.Delay (3000);
	return "foo";
}