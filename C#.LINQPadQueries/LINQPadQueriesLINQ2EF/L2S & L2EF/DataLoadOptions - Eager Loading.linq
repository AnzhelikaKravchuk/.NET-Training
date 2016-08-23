<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// In this example we're using DataLoadOptions for eager loading. Notice that only
// one SQL query now shows in the SQL results pane, despite using nested foreach
// loops to enumerate the results:

var options = new DataLoadOptions();
options.LoadWith <Customer> (c => c.Purchases);

// Uncomment the following line to specify a filter as well:
// options.AssociateWith <Customer> (c => c.Purchases.Where (p => p.Price > 1000));

LoadOptions = options;

foreach (Customer c in Customers)
{
	Console.WriteLine (c.ID + " " + c.Name);
	foreach (Purchase p in c.Purchases)
		Console.WriteLine ("  - purchased a " + p.Description);
}