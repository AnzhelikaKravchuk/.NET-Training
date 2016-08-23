<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

Customer cust = new Customer { ID=1000, Name="Bloggs" };
Customers.InsertOnSubmit (cust);
SubmitChanges();

Customers.Dump ("After inserting");

cust.Name = "Bloggs2";
SubmitChanges();                 // Updates the customer

Customers.Dump ("After updating");

Customers.DeleteOnSubmit (cust);
SubmitChanges();                 // Deletes the customer

Customers.Dump ("After deleting");