<Query Kind="Statements">
  <Connection>
    <ID>f2f6e2b4-0f40-48df-b2c7-82584a77c393</ID>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\Nutshell.mdf</AttachFileName>
    <Server>.\SQLEXPRESS</Server>
    <AttachFile>true</AttachFile>
    <UserInstance>true</UserInstance>
  </Connection>
</Query>

Regex wordCounter = new Regex (@"\b(\w|[-'])+\b");

// The following query throws an exception, because Regex has no equivalent in SQL:

var query = MedicalArticles
	.Where (article => article.Topic == "influenza"
			&& wordCounter.Matches (article.Abstract).Count < 100);

query.Dump();

//The problem is that SQL Server doesn’t support regular expressions, so the LINQto-
//db providers will throw an exception, complaining that the query cannot be
//translated to SQL