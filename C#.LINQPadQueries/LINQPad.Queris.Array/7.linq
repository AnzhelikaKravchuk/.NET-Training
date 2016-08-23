<Query Kind="Program" />

void Main()
{
	int[] array1 = null;
	Print(array1);
	
	int[] array2 = GenerateArray(0);
	Print(array2);
	
	int[] array3 = GenerateArray(5);
	Print(array3);
	
	ChangeArray(array3);
	Console.WriteLine();
	Print(array3);
}

static int[] GenerateArray(int n)
{
	int[] array = new int[n];
	for (int i = 0; i < n; i++)
	{
		array[i] = i + 1;
	}
	return array;
}

static void Print(int[] array)
{
	if(array == null)
	{
		Console.WriteLine("Argument is null.");
		return;
	}
	
	if (array.Length == 0)
	{
		Console.WriteLine("The number of arguments is 0.");
		return;
	}
	
	for (int i = 0; i < array.Length; i++)
		Console.Write("{0} ",array[i]);
}


static void ChangeArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i]++;
	}
}