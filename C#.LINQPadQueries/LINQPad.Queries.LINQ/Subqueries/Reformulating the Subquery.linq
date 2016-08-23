<Query Kind="Statements" />

// For more information on subqueries, see Chapter 9, "Projecting"

string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

names.Where (n => n.Length == names.OrderBy (n2 => n2.Length)
     							   .Select (n2 => n2.Length).First())
     .Dump();

var query =
	from   n in names
	where  n.Length == (from n2 in names orderby n2.Length select n2.Length)
						.First()
	select n;

query.Dump ("Same thing as a query expression");

//query =
//	from   n in names
//	where  n.Length == names.OrderBy (n2 => n2.Length).First().Length
//	select n;
//
//query.Dump ("Reformulated");
//
//query =
//	from   n in names
//	where  n.Length == names.Min (n2 => n2.Length)
//	select n;
//
//query.Dump ("Same result, using Min aggregation");