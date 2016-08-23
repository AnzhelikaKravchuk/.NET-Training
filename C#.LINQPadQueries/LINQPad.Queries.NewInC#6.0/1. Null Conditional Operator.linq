<Query Kind="Program" />

//Null Conditional Operator or Elvis operator ( ?. )

void Main()
{
	Sample noNullSample = new Sample();

	if (noNullSample != null
		&& noNullSample.FooProperty != null
		&& noNullSample.FooProperty.BarProperty != null)
	{
		noNullSample.FooProperty.BarProperty.DoSomething();
	}
	//vs
	"-------------------".Dump();
	(noNullSample == null ? null : 
		noNullSample.FooProperty == null ? null : 
		noNullSample.FooProperty.BarProperty == null ? null : 
		noNullSample.FooProperty.BarProperty).DoSomething();
	//vs
	"-------------------".Dump();
	noNullSample?.FooProperty?.BarProperty?.DoSomething();
	"-------------------".Dump();
	Sample nullSample = null;
	nullSample.Dump();
	nullSample?.FooProperty?.BarProperty?.DoSomething();
}

public class Sample
{
	public Foo FooProperty { get; set; } = new Foo();
}

public class Foo
{
	public Bar BarProperty { get; set; } = new Bar();
}

public class Bar
{
	public void DoSomething()
	{
		Console.WriteLine("Doing something");
	}
}