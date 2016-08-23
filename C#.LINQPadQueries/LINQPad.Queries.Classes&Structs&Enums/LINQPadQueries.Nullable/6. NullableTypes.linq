<Query Kind="Program" />

void Main()
{
	int? parsed = TryParse("Not valid");
	if (parsed != null)
	{
		Console.WriteLine("Parsed to {0}", parsed.Value);
	}
	else
	{
		Console.WriteLine("Couldn't parse");
	}
}
//TryXXX pattern
static int? TryParse(string text)
{
	int ret;
	if (int.TryParse(text, out ret))
	{
		return ret;
	}
	else
	{
		return null;
	}
}