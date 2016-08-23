<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// In LINQPad we're *inside* the DataContext, so don't need to instantiate it:

Customers                          .Dump ("All customers");
Customers.Count()                  .Dump ("Number of rows in customer table");
Customers.Single (c => c.ID == 2)  .Dump ("Customer with ID of 2");