<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

string str = string.Empty;
for (int i = 1; i <= 1000000; i++)
{
    str += "*";
}
Console.WriteLine("Ok!");//01:05.811!!!!