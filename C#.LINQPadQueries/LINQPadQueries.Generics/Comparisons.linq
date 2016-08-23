<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	string intro1 = Console.ReadLine();
	string intro2 = Console.ReadLine(); 
	Console.WriteLine(intro1 == intro2); 	
	Console.WriteLine(AreEqualString(intro1,intro2)); 
	Console.WriteLine(AreReferenceEqual(intro1, intro2));
	Console.WriteLine(AreRefEqual(intro1, intro2));
	Console.WriteLine(AreEqual(intro1, intro2));

	Console.WriteLine(AreStructEqual(5, 5));
	Console.WriteLine(AreEqual(5, 5));

}

static bool AreEqualString(string first, string second)
{
   return first == second;
}


static bool AreReferenceEqual<T>(T first, T second)
   where T : class
{
   return first == second;
}

static bool AreRefEqual<T>(T first, T second)
   where T : class
{
   return first.Equals(second);
}

static bool AreStructEqual<T>(T first, T second)
   where T : struct
{
	return first.Equals(second);
}

static bool AreEqual<T>(T first, T second)
   where T : IEquatable<T>
{
   return first.Equals(second);//first == null
}