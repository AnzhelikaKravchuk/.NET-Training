<Query Kind="Statements" />

// "Where" is an extension method in System.Linq.Enumerable:

string[] names = { "Tom", "Dick", "Harry" };
//fluent синтаксис
IEnumerable<string> filteredNames = names.Where (n => n.Length >= 4);
	
filteredNames.Dump();//for LINQPad <=> foreach