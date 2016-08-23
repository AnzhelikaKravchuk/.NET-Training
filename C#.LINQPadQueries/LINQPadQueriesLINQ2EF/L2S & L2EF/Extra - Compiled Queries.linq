<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// LINQ to SQL lets you precompile queries so that you pay the cost of translating
// the query from LINQ into SQL only once. In LINQPad the typed DataContext is
// called TypeDataContext, so we proceed as follows:

var cc = CompiledQuery.Compile ((TypedDataContext dc, decimal minPrice) =>    
	from c in Customers
	where c.Purchases.Any (p => p.Price > minPrice)
	select c
);

cc (this, 100).Dump ("Customers who spend more than $100");
cc (this, 1000).Dump ("Customers who spend more than $1000");