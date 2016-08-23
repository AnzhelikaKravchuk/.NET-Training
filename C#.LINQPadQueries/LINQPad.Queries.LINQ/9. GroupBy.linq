<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
}

IEnumerable<Customer> customers = new[]
{
	new Customer{ FirstName = "Luka", LastName="Abrus", Age = 41},
  	new Customer{ FirstName = "Keith", LastName="Harris", Age = 59},
	new Customer{ FirstName = "David", LastName="Pelton", Age = 25},
	new Customer{ FirstName = "John", LastName="Peoples", Age = 37},
	new Customer{ FirstName = "Toni", LastName="Poe", Age = 29},
	new Customer{ FirstName = "Jeff", LastName="Price", Age = 74}
};

void Main()
{
	var customersGroupedByAgeRange = customers.GroupBy(cust =>
		{
			if (cust.Age < 20)
				return "age < 20";
			if (cust.Age >= 20 && cust.Age < 40)
				return "age >= 20 and < 40";
			if (cust.Age >= 40 && cust.Age < 60)
				return "age >= 40 and < 60";
			if (cust.Age >= 60)
				return "age >= 60";
			return "Error";
		});
	
	customersGroupedByAgeRange.Dump();
	
	foreach (var cust in customersGroupedByAgeRange.OrderBy(cust => cust.Key))
	{
		Console.WriteLine("{0}\t\t{1}", cust.Key, cust.Count());
	}
}