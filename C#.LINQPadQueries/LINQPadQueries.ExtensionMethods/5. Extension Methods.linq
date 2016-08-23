<Query Kind="Program" />

static void Main()
{
	Console.WriteLine ("Perth".IsCapitalized());	
	// Equivalent to:
	Console.WriteLine (StringHelper.IsCapitalized ("Perth"));	
	
	// Interfaces can be extended, too:
	Console.WriteLine ("Seattle".First());   // S
}

public static class StringHelper
{
	public static bool IsCapitalized (this string s)
	{
		if (string.IsNullOrEmpty(s)) return false;
		return char.IsUpper (s[0]);
	}
	
	public static T First<T> (this IEnumerable<T> sequence)
	{
		foreach (T element in sequence)
			return element;
		
		throw new InvalidOperationException ("No elements!");
	}
}