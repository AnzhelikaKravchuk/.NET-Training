<Query Kind="Statements" />

string[] names = { "Tom", "Dick", "Harry" };
IEnumerable<string> filteredNames = from n in names
									where n.Length >= 4
									select n;
filteredNames.Dump();//foreach