<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

Char.GetNumericValue('\u0033').Dump();

Char.GetNumericValue('\u00bc').Dump();//('¼')

Char.GetNumericValue('A').Dump();//-1

int n = 65;
char c = (char)65;
c.Dump();

n = (int)c;
n.Dump();

c = Convert.ToChar(65);
c.Dump();

n = Convert.ToInt32(c);
n.Dump();