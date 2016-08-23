<Query Kind="Statements" />

int[] numbers = { 3, 2, 1 };
Array.Sort (numbers);
numbers.Dump ("Simple sort");

numbers = new[]  { 3, 2, 1 };
string[] words = { "three", "two", "one" };
Array.Sort (numbers, words);
new { numbers, words }.Dump ("Parallel sort");