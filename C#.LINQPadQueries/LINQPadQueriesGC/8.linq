<Query Kind="Program" />

//может ли объект быть собран сборщиком мусора при 
//выполнении экземплярного метода?
#region Advanced
//Экземплярный метод можно рассматривать, как обычный статический
//метод, первым аргументом которого передается this. И если этот 
//"this" не используется на протяжении метода (нет обращения к
//полям объекта), и на этот объект не остается других ссылок из 
//корней приложения, то данный объект может быть собран сборщиком
//мусора до окончания выполнения экземплярного метода.
#endregion

void Main()
{
	var program = new Program();
	program.InstanceMethod();
}

internal class Program
{
	~Program()
	{
		Print("Program.dtor");
	}

	public static void Print(string message)
	{
		GC.Collect();
		GC.WaitForPendingFinalizers();

		Console.WriteLine(message);
	}

	public void InstanceMethod()
	{
		Console.WriteLine("Instance method began");
		Print("Instance method finished");
	}
}