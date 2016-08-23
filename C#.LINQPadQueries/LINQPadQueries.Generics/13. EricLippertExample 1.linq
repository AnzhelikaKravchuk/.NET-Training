<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

#region 1
//Спецификация C# гласит, что когда у вас есть выбор между 
//ReallyDoIt<string>(string) и ReallyDoIt(string) – то есть,
//когда выбор идет из двух методов с идентичными сигнатурами,
//но один из них получает эту сигнатуру после подстановки 
//обобщённых параметров – тогда мы выбираем «натуральную» 
//сигнатуру вместо «подстановленной»
#endregion
//http://blogs.msdn.com/b/ruericlippert/archive/2009/07/30/9888527.aspx
public class C
{
	public static void DoIt<T>(T t)
	{
		ReallyDoIt(t);
	}
	private static void ReallyDoIt(string s)
	{
		Console.WriteLine("строка");
	}
	private static void ReallyDoIt<T>(T t)
	{
		Console.WriteLine("всё остальное");
	}
}

void Main()
{
	C.DoIt(78);
	C.DoIt("string");
	//C.ReallyDoIt("string");
}
//Обобщения работают не так; обобщённые типы – они обобщённые.
//Мы выполняем разрешение перегрузок единожды и замораживаем результат.
//Мы не меняем его во время исполнения, когда кто-то, возможно в совсем другой 
//сборке, использует строку как тип-аргумент для метода. 
//Уже выбран метод, который будет вызваться в IL, сгенерированном
//нами для обобщённого типа. Компилятор JIT не говорит «ага, я тут случайно
//знаю, что, если бы мы попросили компилятор C# сейчас выполниться, имея эту 
//дополнительную информацию, то он бы выбрал другой перегруженный метод. 
//Дай-ка я перепишу код, исходно сгенерированный компилятором C#...». 
//Компилятор JIT ничего не знает о правилах C#.

public class B
{
  public static void DoIt(object t)
  {
    ReallyDoIt(t);
  }
  private static void ReallyDoIt(string s)
  {
    System.Console.WriteLine("строка");
  }
  private static void ReallyDoIt(object t)
  {
    System.Console.WriteLine("всё остальное");
  }
}