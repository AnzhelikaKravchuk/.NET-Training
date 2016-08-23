<Query Kind="Program" />

#region Description
// если один из них имеет более специфичные аргументы, то ему будет отдано предпочтение
// классы и структуры более специфичны, чем интерфейсы
// Если два метода расширения имеют одинаковые сигнатуры, они должны вызываться 
// как статические
#endregion

static void Main()
{
	Console.WriteLine("Test".IsCapitalized());
}

static class StringHelper
{
	public static bool IsCapitalized (this string s)
	{
		Console.WriteLine("StringHelper");
		return char.IsUpper(s[0]);
	}
}

static class EnumerableHelper
{
	public static bool IsCapitalized (this IEnumerable<char> s)
	{
		Console.WriteLine("Enumerable");
		return char.IsUpper (s.First());
	}
}