<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

int[] numbers = { 10, 5, 13, 18, 4, 24, 65, 41, 30 };

var evens = from number in numbers
			where (number  % 2) == 0
			orderby number
			select number;

foreach (int number in evens)
{
	Console.WriteLine(number);
}