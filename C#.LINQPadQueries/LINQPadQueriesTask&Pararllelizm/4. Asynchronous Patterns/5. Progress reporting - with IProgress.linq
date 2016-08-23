<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//The CLR provides a pair of types to solve this problem: an interface 
//called IProgress<T> and a class that implements this interface called
//Progress<T>. Their purpose, in effect, is to "wrap" a delegate, so that 
//UI applications can report progress safely through the synchronization 
//context.

//public interface IProgress<in T>
//{
//	void Report (T value);
//}

async void Main()
{
	var progress = new Progress<int> (i => Console.WriteLine (i + " %"));
	//после создания экземпляра Progress<int> захватывается контекст 
//	синхронизации, через который и вызывается делегат при обращении к Report
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