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

// Click the 'SQL' tab below after running this query - notice that only the topic filtering
// predicate executes on SQL Server.

var query = MedicalArticles
	.Where (article => article.Topic == "influenza")
	.AsEnumerable()
	.Where (article => wordCounter.Matches (article.Abstract).Count < 100);

query.Dump();