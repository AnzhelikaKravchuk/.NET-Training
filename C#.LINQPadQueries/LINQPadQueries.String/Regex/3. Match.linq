<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

Regex r = new Regex(@"[-+]?\d+");
string text = @"5*10=50 -80/40=-2рлрло 77";
Match teg1 = r.Match(text);
int sum = 0;
while (teg1.Success)
{
	teg1.Dump();
	sum += int.Parse(teg1.ToString());
	teg1 = teg1.NextMatch();
}
Console.WriteLine("\nsum = {0}", sum);

MatchCollection teg = r.Matches(text);
teg.Dump();
sum = 0;
foreach (Match temp in teg)
{
	sum += int.Parse(temp.ToString());
}
Console.WriteLine("\nsum = {0}", sum);