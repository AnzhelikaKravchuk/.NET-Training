<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

async void Main()
{
	Task task1 = Task.Run (() => { throw new NullReferenceException(); } );
	Task task2 = Task.Run (() => { throw new ArgumentException(); } );
	Task all = Task.WhenAll (task1, task2);
	try { await all; }
	catch
	{
		all.Exception.Dump();
		Console.WriteLine (all.Exception.InnerExceptions.Count);   // 2 
	}    
}