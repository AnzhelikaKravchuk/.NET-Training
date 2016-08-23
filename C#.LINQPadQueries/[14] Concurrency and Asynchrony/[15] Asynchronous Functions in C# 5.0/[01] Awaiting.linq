<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	DisplayPrimesCount();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

async void DisplayPrimesCount()
{
	int result = await GetPrimesCountAsync (2, 1000000);
	Console.WriteLine (result);
}

Task<int> GetPrimesCountAsync (int start, int count)
{
	return Task.Run (() =>
		ParallelEnumerable.Range (start, count).Count (n => 
			Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));
}