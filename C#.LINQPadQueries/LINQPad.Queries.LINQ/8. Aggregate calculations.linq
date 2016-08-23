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
	Console.WriteLine("Count:{0}\t\tAverage age: {1}\t\tLowest:{2}\t\tHighest:{3}",
		customers.Count(), customers.Average(cust => cust.Age),
		customers.Min(cust => cust.Age), customers.Max(cust => cust.Age));
}