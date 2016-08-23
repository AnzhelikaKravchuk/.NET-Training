<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

// Делегат может иметь более специализированные типы параметров, чем его целевой метод.
// Контрaвариация (Контравиантность)

delegate void StringAction (string s);

static void Main()
{
	StringAction sa = new StringAction(ActOnObject);
	sa("hello");
}

static void ActOnObject(object o)
{
	Console.WriteLine (o);   // hello
}