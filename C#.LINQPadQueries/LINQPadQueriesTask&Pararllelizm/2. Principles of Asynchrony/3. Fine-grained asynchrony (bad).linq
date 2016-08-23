<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//мелкомодульный параллелизм - последовательность небольших параллельных
//операций, между которыми выполнение возвращается вызывающему потоку

void Main()
{
	DisplayPrimeCounts();
}

void DisplayPrimeCounts ()
{
	for (int i = 0; i < 10; i++)
	{
		var awaiter = GetPrimesCountAsync (i * 1000000 + 2, 1000000).GetAwaiter();
		awaiter.OnCompleted (() => 
			Console.WriteLine (awaiter.GetResult() + " primes between " 
			+ (i*1000000) + " and " + ((i+1)*1000000-1)));
	};
	Console.WriteLine ("Done");
}

Task<int> GetPrimesCountAsync (int start, int count)
{
	return Task.Run (() => 
		ParallelEnumerable.Range (start, count).Count (n => 
			Enumerable.Range (2, (int) Math.Sqrt(n)-1).All (i => n % i > 0)));
}