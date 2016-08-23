<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

string source = @"Тучки небесные, вечные странники!";
StringBuilder stringBuilder = new StringBuilder(source.Length);
stringBuilder.Capacity.Dump("capacity");
stringBuilder.MaxCapacity.Dump("max capacity");

StringBuilder sb = new StringBuilder();
sb.Capacity.Dump("capacity");
sb.AppendFormat("{0} {1}", ".NET", "---Framework");
sb.Capacity.Dump("capacity");
string s = sb.Replace("-", " ").Remove(4, 3).ToString();
sb = new StringBuilder();
sb.AppendFormat("{0}{1}", ".NET", "Framework");
s = sb.ToString().ToUpper();
sb.Length = 0;
sb.Append(s).Insert(4, "  ");
s = sb.ToString();
Console.WriteLine(s);