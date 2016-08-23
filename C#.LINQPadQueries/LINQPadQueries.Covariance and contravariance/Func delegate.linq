<Query Kind="Program" />

public delegate TResult Func<in T, out TResult>(T arg);

public class Base {}
public class Derived : Base {}

public static Derived Method(Base b)
{
	return b as Derived ?? new Derived();
}

static void Main() 
{
	Func<Base, Derived> f1 = Method;
	Derived d = f1(new Base());
	d.Dump();
	Func<Derived, Base> f2 = Method;
	Base b = f2(new Derived());
}