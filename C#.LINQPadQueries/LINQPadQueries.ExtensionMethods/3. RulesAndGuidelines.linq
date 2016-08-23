<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

#region Rules and Guidelines
//1. Язык С# поддерживает только методы расширения, он не поддерживает
//свойств расширения, событий расширения, операторов расширения и т. д.

//2. Методы расширения ( методы со словом this перед первым аргументом )
//должны быть объявлены в статическом необобщенном классе.

//3. Компилятор С# ищет методы расширения, заданные только в статических
//классах, определенных в области файла

//4. Компилятору С# необходимо какое-то время для того, чтобы найти
//методы расширения; он просматривает все статические классы, определенные
//в области файла, и сканирует их статические методы

//5. Существует возможность определения в нескольких статических классах
//одинаковых методов расширения

//6. Существует потенциальная проблема с версиями
#endregion

void Main()
{
	// sb is null
	//StringBuilder sb = null;
	StringBuilder sb = new StringBuilder();
	// Calling extension method: NullReferenceException will NOT be thrown when calling IndexOf
	// NullReferenceException will be thrown inside IndexOf’s for loop
	sb.IndexOf('X');
	//Calling instance method: NullReferenceException WILL be thrown when calling Replace
	sb.Replace('.', '!');
	
	//вызов метода на нулевой ссылке
	object obj1 = null;
	obj1.IsNull().Dump("IsNull?");
	object obj2 = new object();
	obj2.IsNull().Dump("IsNull?");
	
	//обертка для статического метода IsNullOrEmpty()
	string str1 = null;
	str1.IsNullOrEmpty().Dump("IsNull?");
	string str2 = string.Empty;
	str2.IsNullOrEmpty().Dump("IsEmpty?");
	string str3 = "Hello!";
	str3.IsNullOrEmpty().Dump("IsEmpty?");
}


public static class StringBuilderExtensions 
{
	public static int IndexOf(this StringBuilder sb, char value) 
	{
		for (int index = 0; index < sb.Length; index++)
			if (sb[index] == value) return index;
		return -1;
	}
}

public static class Extensions
{
	public static bool IsNull(this object obj)
	{
		return obj == null;
	}

	public static bool IsNullOrEmpty(this string text)
	{
		return string.IsNullOrEmpty(text);
	}
}