<Query Kind="Program" />

//методы, принимающие параметры ref или out не могут быгь реализованы 
//в виде итераторных блоков.

//http://blogs.msdn.com/b/ruericlippert/archive/2009/07/20/yield-catch.aspx
// - код в методе GetNumbers() не выполняется до первого обращения 
//к  MoveNext().
// - Вся реальная работа делается при вызове метода  MoveNext(). 
// Во время извлечения свойства Current: никакой код не вычисляется.
// - Код останавливает выполнение на операторе yield return и возобновляет
// его снова при следующем вызове MoveNext().
// -  Можно иметь множество операторов yield return в разных местах метода
// - Код не заканчивается на последнем операторе yield return. 
//Вместо этого вызов метода MoveNext() приводит к концу метода, возвращая false.

public static IEnumerator<int> GetNumbers()
{
	Console.WriteLine("\t\tПервая строка метода GetNumbers()"); // 1
	Console.WriteLine("\t\tСразу перед yield return 7"); // 2
	yield return 7;  // 3
	//Внутри итераторных блоков не разрешены обычные операторы 
	//return, допускаются только yield return
	//Все операторы yield return в блоке должны пытаться 
	//возвращать значение, совместимое с типом возвращаемого значения 
	//блока
	Console.WriteLine("\t\tСразу после yield return 7"); // 4
	Console.WriteLine("\t\tСразу перед yield return 42"); // 5 
	yield return 42;  // 6
	Console.WriteLine("\t\tСразу после yield return 42");  //7
}

void Main()
{
	Console.WriteLine("Вызываем GetNumbers()");
	IEnumerator<int> iterator = GetNumbers();
	Console.WriteLine("Вызываем MoveNext()...");
	bool more = iterator.MoveNext();
	Console.WriteLine("Result={0}; Current={1}", more, iterator.Current);
	Console.WriteLine("Снова вызываем MoveNext()...");
	more = iterator.MoveNext();
	Console.WriteLine("Result={0}; Current={1}", more, iterator.Current);
	Console.WriteLine("Снова вызываем MoveNext()...");
	more = iterator.MoveNext();
	Console.WriteLine("Result={0} (stopping)", more);
//	foreach(var t in GetNumbers())
//		t.Dump();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}