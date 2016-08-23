<Query Kind="Statements" />

//struct Point(!)
//https://msdn.microsoft.com/ru-ru/library/x854yt9s(v=vs.110).aspx
//https://blogs.msdn.microsoft.com/ruericlippert/2011/03/24/1074/
var items = new List<int> { 1, 2, 3 };
items.Dump();
var enumerator = items.GetEnumerator();
enumerator.Dump();

while (enumerator.MoveNext())
{
	enumerator.Current.Dump();
}

var t = new { enumer = items.GetEnumerator()};
while (t.enumer.MoveNext())
{
	t.enumer.Current.Dump();
}

//http://sergeyteplyakov.blogspot.com.by/2012/12/2.html