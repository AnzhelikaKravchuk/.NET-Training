<Query Kind="Program" />

// Методы расширения, подобно методам экземпляра, прелоставляют аккуратный 
// способ для связывания функций в цепочку

static void Main()
{
	string x = "sausage".Pluralize().Capitalize();
	x.Dump();
	
	// Equivalent to:
	string y = StringHelper.Capitalize (StringHelper.Pluralize ("sausage"));
	y.Dump();
	
	// LINQPad's Dump method is an extension method:
	"sausage".Pluralize().Capitalize().Dump();
}

public static class StringHelper
{
	public static string Pluralize (this string s)
	{
		return s + "s";   // Very naive implementation!
	}
	
	public static string Capitalize (this string s)
	{
		return s.ToUpper();
	}
}