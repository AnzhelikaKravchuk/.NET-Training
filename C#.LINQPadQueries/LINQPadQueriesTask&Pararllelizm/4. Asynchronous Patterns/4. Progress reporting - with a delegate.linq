<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Action<int> progress = i => Console.WriteLine ((i + 1) + " %");
	await Foo (progress);
}

Task Foo (Action<int> onProgressPercentChanged)
{
	return Task.Run (() =>
	{
		for (int i = 0; i < 1000; i++)
		{
			if (i % 10 == 0) onProgressPercentChanged (i / 10);
			// Do something compute-bound...
			//it’s not ideal in rich client scenarios because it reports
			//progress from a worker thread, causing potential thread-safety
			//issues for the consumer
		}
	});
}