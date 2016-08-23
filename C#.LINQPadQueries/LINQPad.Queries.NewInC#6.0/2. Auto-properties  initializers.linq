<Query Kind="Program" />

//В C# 6.0 мы можем инициализировать свойства со значениями,
//написав справа от них их значение. Это поможет избежать
//ошибки с null и пустыми значениями свойства.

void Main()
{
	Customer customer = new Customer();
	customer.Id.Dump("Id = ");
	customer.First.Dump("First = ");
	customer.Last.Dump("Last = ");
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

public class Customer
{
	//Getter-only auto-properties
	//The backing field of a getter-only auto-property 
	//is implicitly declared as readonly
	public Guid Id { get; }
	public string Name { get; }
	
	//Initializers for auto-properties
	//The initializer directly initializes the backing field;
	//it doesn’t work through the setter of the auto- property
    public string First { get; set; } = "Jane";
	public string Last { get; set; } = "Doe";	
	
	public Customer()
	{
		this.Id = Guid.NewGuid();
	}
	
	public Customer(string first, string last)
    {
        Name = first + " " + last;
    }
}

//The initializer directly initializes the backing field; 
//it doesn’t work through the setter of the auto- property. 
//The initializers are executed in order as written, 
//just as – and along with – field initializers.
//Just like field initializers, auto-property initializers 
//reference ‘this’ – after all they are executed before 
//the object is properly initialized. This would mean that
//there aren’t a whole lot of interesting choices for what 
//to initialize the auto-properties to. However, primary 
//constructors change that. Auto- property initializers
//and primary constructors thus enhance each other.