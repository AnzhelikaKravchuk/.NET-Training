<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

//Regex r = new Regex("собака", RegexOptions.IgnoreCase);
//string text1 = "Кот в доме, собака в конуре.";
//string text2 = "Котик в доме, собачка в конуре.";
//Console.WriteLine(r.IsMatch(text1)); //True
//Console.WriteLine(r.IsMatch(text2)); //False

Regex r = new Regex(@"\d{2,3}(-\d\d){2}");
string text1 = "tel:123-45-67";
string text2 = "tel:no";
string text3 = "tel:12-34-56";
Console.WriteLine(r.IsMatch(text1));//True
Console.WriteLine(r.IsMatch(text2));//False
Console.WriteLine(r.IsMatch(text3));//True