<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

string s = "Это текстовая строка, состоящая из семи слов.";
s.Dump("строка = ");
Console.WriteLine("Длина строки {0}", s.Length);
Console.WriteLine("Наличие подстроки \"текст\"? {0} ", s.Contains("текст"));
Console.WriteLine("Вставка \"{0}\"", s.Insert(4, "большая "));
Console.WriteLine("Длина строки {0} символов", s.Length);
Console.WriteLine("Удаление:\"{0}\"", s.Remove(4, 10));
Console.WriteLine("Замена: \"{0}\"", s.Replace("семи", "нескольких"));
Console.WriteLine("Подстрока: \"{0}\"", s.Substring(4, 5));
Console.WriteLine("В верхний регистр: {0}", s.ToUpper());
Console.WriteLine("Вхождение \"текст\": {0}", s.IndexOf("текст"));
s.Dump("строка = ");