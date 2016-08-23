<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var cancelSource = new CancellationTokenSource();
	var token = cancelSource.Token;
	await Task.Delay (5000).ContinueWith (ant => cancelSource.Cancel());   // Tell it to cancel in two seconds.
	try
	{
		await Foo (token);
	}
	catch(OperationCanceledException ocex)
	{
		ocex.Dump();
	}
}

async Task Foo (CancellationToken cancellationToken)
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine (i);
		await Task.Delay (1000);
		cancellationToken.ThrowIfCancellationRequested();
	}
}