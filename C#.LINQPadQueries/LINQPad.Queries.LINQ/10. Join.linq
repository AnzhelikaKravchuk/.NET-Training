<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Customer
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public int Age { get; set; }
	public string CompanyName { get; set; }
}

class Company
{
	public string CompanyName { get; set; }
	public string Country { get; set; }
}

IEnumerable<Customer> customers = new[]
{
	new Customer {FirstName = "Luka", LastName = "Abrus", Age = 41,CompanyName = "Contoso"},
	new Customer {FirstName = "Syed", LastName = "Abbas", Age = 23,CompanyName  = "Contoso"},
	new Customer {FirstName = "Keith", LastName = "Harris", Age = 59,CompanyName = "Fabrikam"},
	new Customer {FirstName = "Keith", LastName = "Harris", Age = 59,CompanyName = "Fabrikam"},
	new Customer {FirstName = "David", LastName = "Pelton", Age = 25,CompanyName = "Contoso"},
	new Customer {FirstName = "John", LastName = "Peoples", Age = 37,CompanyName = "Fabrikam"},
	new Customer {FirstName = "Toni", LastName = "Poe", Age = 29,CompanyName = "Fabrikam"},
	new Customer {FirstName = "Jeff", LastName = "Price", Age = 74,CompanyName = "Contoso"}
};

IEnumerable<Company> companies = new[]
{
	new Company {CompanyName = "Contoso", Country = "United Kingdom"},
	new Company {CompanyName = "Fabrikam", Country = "United States"}
};

void Main()
{
	var customersAndCompanies = customers.Join(
				companies, 
				custs => custs.CompanyName, 
				comps => comps.CompanyName, 
				(custs, comps) => 
				new { custs.FirstName, custs.LastName, comps.Country});

	
	customersAndCompanies.Dump();
}