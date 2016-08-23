<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

string text = @"Контактные телефоны tel: 123-45-67, 123-34-56; fax:123-56-45";
Console.WriteLine("Старые данные\n" + text);
string newText = Regex.Replace(text, @"\d{2,3}(-\d\d){2}", "");
newText.Dump("Новые данные");

string text1 = @"Контакты телефоны: 123-45-67, 123-34-56";
string[] newText1 = Regex.Split(text1, "[ ,.:;]+");
newText1.Dump("Новые данные");