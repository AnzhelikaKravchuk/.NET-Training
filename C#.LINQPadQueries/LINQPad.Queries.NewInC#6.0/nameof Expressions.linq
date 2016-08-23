<Query Kind="Program">
  <Namespace>System.ComponentModel</Namespace>
</Query>

void Main()
{
	Sample s = new Sample();
	Sample1 s1 = new Sample1(s);
	s.Name = "Test";
	
	s = null;
	try
	{	        
		
		DoSomething(s);
	}
	catch (Exception ex)
	{
		ex.Dump();
	}
}

class Sample1
{
	public Sample1(Sample o)
	{
		o.PropertyChanged += Foo;
	}

	public static void Foo(object o, PropertyChangedEventArgs arg)
	{
		arg.PropertyName.Dump();
		arg.Dump();
	}
}

public class Sample : INotifyPropertyChanged
{
	private string name;

	public string Name
	{
		get { return name; }
		set
		{
			name = value;
			NotifyPropertyChanged(nameof(Name));
		}
	}

	public void NotifyPropertyChanged(string propName)
	{
		if (PropertyChanged != null)
			PropertyChanged(this,
				new PropertyChangedEventArgs(propName));
	}

	public event PropertyChangedEventHandler PropertyChanged;
}

public void DoSomething(object someParam)
{
	if (someParam == null)
	{
		throw new ArgumentNullException(nameof(someParam));
	}
	//...    
}