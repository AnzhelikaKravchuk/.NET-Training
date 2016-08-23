<Query Kind="Program" />

//В C# 6.0 свойства и методы можно определять через 
//лямбда-выражения. Существенно уменьшает количество кода.

void Main()
{
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

class Point
{
	private int x, y;
	public Point(int x, int y) { }
	//...
	//Expression bodies on method-like members
	public Point Move(int dx, int dy) => new Point(x + dx, y + dy);
//	public Point Move(int dx, int dy)
//	{
//		return new Point(x + dx, y + dy);
//	}
}

class Complex
{
	//Expression bodies on method-like members
	public static Complex operator +(Complex a, Complex b) => Add(a, b);
	
	public static Complex Add(Complex lhs, Complex rhs)
	{
		//TODO
		return new Complex(); 
	}
}

class Customer
{
	public string First { get; }
	public string Last { get; }
	//...
	//Expression bodies on method-like members
	public static implicit operator string(Customer p)
          => p.First + " " + p.Last;
	//Expression bodies on method-like members	  
	public void Print() => Console.WriteLine(First + " " + Last);
	
	//Expression bodies on property-like function members
	public string Name => First + " " + Last;
    //public Customer this[long id] => store.LookupCustomer(id);

}