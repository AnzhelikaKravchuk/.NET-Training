<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	Console.WriteLine(CompareToDefault("x")); 
	Console.WriteLine(CompareToDefault(10)); 
	Console.WriteLine(CompareToDefault(0)); 
	Console.WriteLine(CompareToDefault(-10)); 
	Console.WriteLine(CompareToDefault(DateTime.MinValue));
}

static int CompareToDefault<T>(T value)
   where T : IComparable<T>
{
	return value.CompareTo(default(T));
}

