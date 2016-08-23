<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// If we simply enumerate without projecting, then LINQ to SQL round-trips
// on each EntitySet (look at the SQL results pane).

foreach (Customer c in Customers)
	foreach (Purchase p in c.Purchases)    // Another SQL round-trip
		Console.WriteLine (c.Name + " spent " + p.Price);