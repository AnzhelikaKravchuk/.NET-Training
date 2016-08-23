<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// The following example uses DataLoadOptions for filtering. To see its effect, first highlight
// just the foreach loop, and execute that, then execute the entire query for comparison:

var options = new DataLoadOptions();
options.AssociateWith <Customer> (c => c.Purchases.Where (p => p.Price > 1000));
LoadOptions = options;

foreach (Customer c in Customers)
{
	Console.WriteLine (c.ID + " " + c.Name);
	foreach (Purchase p in c.Purchases)
		Console.WriteLine ("  - purchased a " + p.Description);
}

// Notice in the SQL results pane, that this use of DataLoadOptions doesn't prevent
// the excessive round-tripping that comes from using nested foreach loops to
// enumerate the results.