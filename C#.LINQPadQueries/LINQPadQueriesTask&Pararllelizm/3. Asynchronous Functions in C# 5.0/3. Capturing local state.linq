<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	DisplayPrimeCounts();
}
//an await expression can appear in place of any expression (within an
//asynchronous function) except for inside a catch or finally block (before C# 6.0!), 
//lock expression, unsafe context or an executable’s entry point 
//(main method).

async void DisplayPrimeCounts()
{
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine (await GetPrimesCountAsync (i*1000000+2, 1000000));
	}
}

Task<int> GetPrimesCountAsync (int start, int count)
{
  return Task.Run (() =>
	ParallelEnumerable.Range (start, count).Count (n => 
	  Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));
}