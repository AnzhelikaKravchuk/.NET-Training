<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

const int n = 3;
int[][] myArray = new int[n][];
for (int i = 0; i < myArray.Length; i++)
{
	Console.Write("Введите элементы {0} строки: ", i);
	string line = Console.ReadLine();
	char[] separator = {' '};
	string[] mas = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
	myArray[i] = new int[mas.Length];
	for (int j = 0; j < myArray[i].Length; j++)
	{
		myArray[i][j] = int.Parse(mas[j]);
	}
}

for (int i = 0; i < myArray.Length; i++)
{
	Console.WriteLine();
	foreach (int x in myArray[i])
	{
		Console.Write("{0} ", x);
	}
	Console.WriteLine();
}