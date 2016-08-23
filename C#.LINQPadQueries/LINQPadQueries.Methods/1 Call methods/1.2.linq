<Query Kind="Program" />

class Demo
{
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    static void Main(string[] args)
    {
//        int x = 1, y = 2, z = 3;
//        var obj = new Demo();
//		int t = obj.Sum(x++, y += x + 3, z *= y - 4);
		int x = 1;
		int y = ++x;

		Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
    }
}