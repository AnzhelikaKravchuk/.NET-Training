<Query Kind="Program" />

void Main()
{

}

class B 
{
	public virtual void M(double x) { }
	
	public virtual void M(int x) { }
}

class C
{
	public static void X(B b, dynamic d)
	{
		b.M(d);//связывание практически полностью отложено до времени выполнения
	}
}