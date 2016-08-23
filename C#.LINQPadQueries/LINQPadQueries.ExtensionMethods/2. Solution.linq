<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

public void Main()
{
	StringBuilder sb = new StringBuilder("Hello, world.");
	
	int index = sb.Replace('.', '!').IndexOf('!');
	index.Dump("index");
}


public static class StringBuilderExtensions 
{
	public static int IndexOf(this StringBuilder sb, char value) 
	{
		for (int index = 0; index < sb.Length; index++)
			if (sb[index] == value) return index;
		return -1;
	}
}