<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

var str = new StringBuilder();
for (int i = 1; i <= 1000000; i++)
{
    str.Append("*");
}
str.ToString();
Console.WriteLine("Ok!");