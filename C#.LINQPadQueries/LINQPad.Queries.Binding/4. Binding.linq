<Query Kind="Program" />

void Main()
{

}

class B 
{
	public virtual void M(double x) { }
	
	public virtual void M(int x) { }
}

class A : B
{
	public override void M(int x) { }
}

class C
{
	public static void X(B b, int d)
	{
		b.M(d);//b может быть ссылкой на объект производного класса A
	}
}

//Диспетчеризация виртуальных методов является формой позднего связывания