<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

// The following query returns all purchases with a null CustomerID:

Purchases.Where (p => p.CustomerID == null)
	.Dump ("Customers with null CustomerID, using a null literal");

// Look at the SQL translatation - the predicate reads "WHERE [t0].[CustomerID] IS NULL".
// The "IS" keyword in SQL is essential here, to avoid running afoul of SQL's three-value null logic.
// If it translated instead to "WHERE [t0].[CustomerID] = NULL" we would get no rows back.

// But suppose that you want to use a variable instead of a literal, in other words:

int? customerID = null;
Purchases.Where (p => p.CustomerID == customerID)
	.Dump ("Customers with a null CustomerID, using a variable");

// Notice, now, that no results are returned. We can see why by looking at the SQL: the
// the predicate translates to: "WHERE [t0].[CustomerID] = @p0".

// Fortunately, there's an easy workaround. If you use the static object.Equals method to
// perform the equality comparison, LINQ to SQL emits an "IS NULL" expression if the value
// is null, otherwise it emits an "= @p" expression:

Purchases.Where (p => object.Equals (p.CustomerID, customerID))
	.Dump ("Using the static object.Equals method, with a null variable");

customerID = 1;			
Purchases.Where (p => object.Equals (p.CustomerID, customerID))
	.Dump ("Using the static object.Equals method, with a non-null variable");