<Query Kind="Expression">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// Look at the SQL results pane - only one SQL statement is generated as LINQPad
// enumerates the results of this query.

from c in Customers
select 
	from p in c.Purchases
	select new { c.Name, p.Price }