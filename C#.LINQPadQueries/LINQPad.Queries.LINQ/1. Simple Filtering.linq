<Query Kind="Statements" />

string[] names = { "Tom", "Dick", "Harry" };

IEnumerable<string> filteredNames =
	System.Linq.Enumerable.Where (names, n => n.Length >= 4);
                                    
foreach (string n in filteredNames)
	Console.Write (n + "|");            // Dick|Harry|


// In LINQPad, we can also write query results using Dump (foreach):

filteredNames.Dump ("Simple use of 'Where' query operator");