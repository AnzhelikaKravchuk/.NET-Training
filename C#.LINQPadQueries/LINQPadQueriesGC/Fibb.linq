<Query Kind="Program" />

void Main()
{
	foreach (var t in Fibonacci(4))
		t.Dump();
}

public static IEnumerable<int> Fibonacci(int count)
{
	if (count <= 0)
		throw new ArgumentException();
	yield return 1;
	int first = 0, second = 1;
	for (int i = 2; i <= count; i++)
	{
		int temp = first + second;
		yield return temp;
		first = second;
		second = temp;
	}
}