<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

Customer cust1 = Customers.OrderBy (c => c.Name).First();

foreach (Purchase p in cust1.Purchases)
	Console.WriteLine (p.Price);
	
// Retrieve the customer who made the lowest value purchase:

Purchase cheapest = Purchases.OrderBy (p => p.Price).First();
cheapest.Customer.Dump();