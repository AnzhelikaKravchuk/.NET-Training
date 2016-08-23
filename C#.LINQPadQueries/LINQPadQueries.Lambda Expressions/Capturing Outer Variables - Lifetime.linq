<Query Kind="Program" />

// Captured variables have their lifetimes extended to that of the delegate:

static Func<int> Natural()
{
	int seed = 0;
	return () => seed++;	  // Returns a closure
}

static void Main()
{
	Func<int> natural = Natural();
	Console.WriteLine (natural());      // 0
	Console.WriteLine (natural());      // 1
	//Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}