<Query Kind="Program" />

// A delegate type declaration is like an abstract method declaration,
// prefixed with the delegate keyword:

delegate int Transformer (int x);

static void Main()
{
	Transformer t = Square;
//	Transformer t1 = Cube;
//	t.GetHashCode().Dump();
//	t1.GetHashCode().Dump();
//	t += Cube;
//	t += Square;
	t.Dump();
//	t1 += Cube;
//	t.GetHashCode().Dump();
//	t1.GetHashCode().Dump();
	int result = t(3);
	Console.WriteLine(result);
	result = t(4);
	Console.WriteLine(result);
	//Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",
	//	Assembly.GetExecutingAssembly().Location);
}

static int Square(int x) { return x * x; }
static int Cube(int x) { return x * x * x; }