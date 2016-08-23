<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	var progress = new Progress<int>(i => Console.WriteLine (i + " %"));
	//progress.ProgressChanged += (sender, args) => Console.WriteLine ((int)args + " %");
	await Foo (progress);
}

Task Foo (IProgress<int> onProgressPercentChanged)
{
	return Task.Run (() =>
	{
		for (int i = 0; i < 1000; i++)
		{
			if (i % 10 == 0) onProgressPercentChanged.Report (i / 10);
			// Do something compute-bound...
		}
	});
}