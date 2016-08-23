<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

int[] numbers = { 10, 5, 13, 18, 4, 24, 65, 41, 30 };

List<int> evens = new List<int>();

foreach (var number in numbers)
{
	if (number % 2 == 0)
		evens.Add(number);
}

evens.Sort();

foreach (int number in evens)
{
	Console.WriteLine(number);
}