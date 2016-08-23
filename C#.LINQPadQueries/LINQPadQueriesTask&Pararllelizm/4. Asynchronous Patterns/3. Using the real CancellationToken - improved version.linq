<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Do();
}

async void Do()
{
	var cancelSource = new CancellationTokenSource(5000);   // This tells it to cancel in 5 seconds
															//method Register CancellationToken 
	try
	{
		await Foo(cancelSource.Token);
	}
	catch (OperationCanceledException ex)
	{
		//ex.Dump();
		"Task cancelled!".Dump();
	}
}

async Task Foo(CancellationToken cancellationToken)
{
	for (int i = 0; i < 10; i++)
	{
		Console.Write(i);
		await Task.Delay(1000, cancellationToken);  // Cancellation tokens propagate nicely
	}
}