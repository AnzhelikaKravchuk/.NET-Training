<Query Kind="Program" />

class Customer
{
	public string FirstName{ get; set; }
	public string LastName{ get; set; }
	public int Age{ get; set; }
}

void Main()
{
		IEnumerable<Customer> _customers = new[]
		{
	    	new Customer{ FirstName = "Luka", LastName="Abrus", Age = 41},
	    	new Customer{ FirstName = "Syed", LastName="Abbas", Age = 23},
	   		new Customer{ FirstName = "Keith", LastName="Harris", Age = 59},
	    	new Customer{ FirstName = "David", LastName="Pelton", Age = 25},
	    	new Customer{ FirstName = "John", LastName="Peoples", Age = 37},
	    	new Customer{ FirstName = "Toni", LastName="Poe", Age = 29},
	    	new Customer{ FirstName = "Jeff", LastName="Price", Age = 74}
	    };
		
		IEnumerable<string> customerLastNames = 
                       _customers.Select(cust => cust.LastName);
					   
		foreach (var element in customerLastNames)
		{
			element.Dump();
		}
		Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 7.7\Reflector.exe", Assembly.GetExecutingAssembly().Location);
}
