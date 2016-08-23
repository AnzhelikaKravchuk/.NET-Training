<Query Kind="Program" />

void Main()
{
	Sample5 sm = new Sample5();
	sm.Guid.Dump();
	sm.GuidNew.Dump();
	sm.Guid.Dump();
	sm.GuidNew.Dump();
	//Process.Start(@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}

//vs C# 5.0
public class Sample1
{
	private readonly string name = "Default initial value";
	//public string Name { get { return name; } set { name = value; } }
	public string Name { get { return name; } }

}

//immutable outside only! C# 5.0
public class Sample2
{
	public Sample2()
	{
		Name = "Default initial value";
	}
	public string Name { get; private set; }
	//public string Name { get; set; }
	
	//immutable outside only! C# 5.0
	public void Foo(string name)
	{
		Name = name;
	}
}

//vs C# 6.0
public class Sample3
{
	//Initializers for auto-properties
	//The initializer directly initializes the backing field;
	//it doesn’t work through the setter of the auto- property
	public string Name { get; set; } = "Default initial value";
}

//vs C# 6.0
//immutable inside!
public class Sample4
{
	//implicitly declared field as readonly
	public string Name { get; } = "Default initial value";
}

public class Sample5
{
	public Guid Guid { get; } = Guid.NewGuid();
	public Guid GuidNew => Guid.NewGuid();
}