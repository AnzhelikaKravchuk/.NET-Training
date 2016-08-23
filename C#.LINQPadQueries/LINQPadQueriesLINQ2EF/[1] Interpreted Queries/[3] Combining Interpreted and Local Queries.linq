<Query Kind="Program">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

void Main()
{
	// This uses a custom 'Pair' extension method, defined below.
	
	IEnumerable<string> q = Customers
		.Select (c => c.Name.ToUpper())
		.Pair()									// Local from this point on.
		.OrderBy (n => n);
	
	q.Dump();	
}

public static class MyExtensions
{
	public static IEnumerable<string> Pair (this IEnumerable<string> source)
	{
		string firstHalf = null;
		foreach (string element in source)
		if (firstHalf == null)
			firstHalf = element;
		else
		{
			yield return firstHalf + ", " + element;
			firstHalf = null;
		}
	}
}