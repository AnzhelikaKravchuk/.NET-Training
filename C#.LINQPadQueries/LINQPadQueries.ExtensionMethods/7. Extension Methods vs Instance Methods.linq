<Query Kind="Program" />

// Любой совместимый метод экземпляра будет иметь преимущество над расширяющим методом

static void Main()
{
	new Test().Foo ("string");	// Instance method wins, as you'd expect
	new Test().Foo (123);		// Instance method still wins
	StringHelper.Foo(new Test(),123);
}

public class Test
{
	public void Foo (object x) { "Instance".Dump(); }    // This method always wins
}

public static class StringHelper
{
	public static void Foo(this Test t, int x) { "Extension".Dump(); }
}