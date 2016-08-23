<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

Customer a = Customers.Where (c => c.Name.StartsWith ("T")).First();
Customer b = Customers.OrderBy (c => c.ID).First();

a.Dump();
b.Dump();

(a == b).Dump();