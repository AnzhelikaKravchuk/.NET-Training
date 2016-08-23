<Query Kind="Program" />

void Main()
{
	B b = new B();
	Console.WriteLine("Исходное значение M.X: {0}", b.M.X);
	//согласно спецификации, при обращении к полю только для чтения вне
	//конструктора, генерируется временная переменная, для которой и 
	//вызывается метод IncrementX

	b.M.IncrementX();//Mutable tmp1 = b.M;tmp1.IncrementX();
	b.M.IncrementX();//Mutable tmp2 = b.M;tmp2.IncrementX();
	b.M.IncrementX();//Mutable tmp3 = b.M;tmp3.IncrementX();
	Console.WriteLine("M.X после трех вызовов IncrementX: {0}", b.M.X);
}

struct Mutable
{
	public Mutable(int x, int y)
	{
		X = x;
		Y = y;
	}
	public void IncrementX() { X++; }
	public int X { get; private set; }
	public int Y { get; set; }
}

class B
{
	public B()
	{
		//M.IncrementX();
	}
	public readonly Mutable M = new Mutable(x: 5, y: 5);
}