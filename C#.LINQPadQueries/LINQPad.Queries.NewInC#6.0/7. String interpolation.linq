<Query Kind="Statements" />

var name = "Chuck";
var surname = "Norris";
string message45 = string.Format("The man is {0} {1}",name,surname); 
string message46 = $"The man is {name} {surname}";
message45.Dump();
message46.Dump();

var numbers = new int[] { 1, 2, 3, 4, 5 };
string message = $"There are {numbers.Length} numbers, and their average is {numbers.Average()}";
message.Dump();

var dateOfBirth = DateTime.Now;
string messageDate = $"It's {dateOfBirth:yyyy-MM-dd}!";
messageDate.Dump();