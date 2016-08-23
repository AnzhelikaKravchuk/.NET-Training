<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

string source = "тучки небесные вечные странники";
char[] separators = { ' ' };
string[] parts = source.Split(separators);
Console.WriteLine("Результат разбиения строки на части: ");
for (int i = 0; i < parts.Length; i++)
{
	Console.WriteLine(parts[i]);
}
string result = String.Join(" | ", parts);
Console.WriteLine("Результат сборки: ");
Console.WriteLine(result);