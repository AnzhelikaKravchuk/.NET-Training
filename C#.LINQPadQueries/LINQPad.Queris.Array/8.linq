<Query Kind="Statements" />

int[] array = {1, 2, 3,  4, 5};

for (int i = 0; i < array.Length; i++)
{
	Console.WriteLine("i = {0} A[{1}] = {2} ", i, i,  array[i]);
}


Console.WriteLine();
foreach (int element in array)
{
	Console.Write("{0} ",element);
}