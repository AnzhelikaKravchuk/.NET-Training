<Query Kind="Program" />

void Main()
{
	foreach(var t in CountToTen())
	{
		t.Dump();
	}
}

IEnumerable<int> CountToTen()
{
    System.Console.WriteLine("1");
    yield return 0;
    System.Console.WriteLine("2");
    System.Console.WriteLine("3");
    System.Console.WriteLine("4");
    yield return 0;
    System.Console.WriteLine("5");
    System.Console.WriteLine("6");
    System.Console.WriteLine("7");
    yield return 0;
    System.Console.WriteLine("8");
    yield return 0;
    System.Console.WriteLine("9");
    System.Console.WriteLine("10");
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}