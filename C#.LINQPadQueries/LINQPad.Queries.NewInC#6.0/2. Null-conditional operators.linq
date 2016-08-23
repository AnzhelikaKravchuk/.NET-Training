<Query Kind="Program" />

void Main()
{
	Customer[] customers = new Customer[2] 
	{ 
		new Customer { First = "Joe", Last = "Smit" },
		new Customer { First = "Jon", Last = "Smitty" }
	};
	
	//before С# 6.0
	{
		int? length = customers == null ? null : (int?)customers.Length;
		string nameFirst = customers == null ? null : customers[0] == null ? null : customers[0].First;
		nameFirst.Dump();
	}

	//C# 6.0
	//Null-conditional operators
	{
		int? length = customers?.Length; // null if customers is null
		string nameFirst = customers?[0]?.First;  // null if customers is null
		nameFirst.Dump();
	}
	
	//The null-conditional operator is conveniently used together with the null coalescing operator ??:
	Customer[] customers1 = null;
	int length1 = customers1?.Length ?? 0; // 0 if customers is null
	length1.Dump();
}

public class Customer
{
	public Guid Id { get; } 
	public string Name { get; }

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