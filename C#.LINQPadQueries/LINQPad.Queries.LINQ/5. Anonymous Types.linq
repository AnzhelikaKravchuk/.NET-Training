<Query Kind="Program">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	
	public Func<int> del = () => 5; 
}
	
IEnumerable<Customer> _customers = new[]
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
	var customerNames = _customers.Select(cust => new 
							{
								first = cust.FirstName,
								cust.LastName,
								Mix = cust.FirstName + ' ' + cust.LastName,
								Length = (cust.FirstName + ' ' + cust.LastName).Length,
								del = cust.del
							});
	foreach(var t in customerNames)
		Console.WriteLine(t.del());
	
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}