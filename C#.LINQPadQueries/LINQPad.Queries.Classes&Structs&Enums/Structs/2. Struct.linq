<Query Kind="Program" />

#region Value types
//http://sergeyteplyakov.blogspot.com/2012/09/blog-post.html
//конструктор по умолчанию (default constructor) 
//и значения по умолчанию (default values)

//Конструктором по умолчанию в языке C# называется инструкция обнуления значения объекта.
//С точки зрения CLR конструкторы по умолчанию существуют и язык C# даже умеет их вызывать.
//Язык C# не позволяет создавать пользовательские конструкторы по умолчанию для структур, 
//поскольку это привело бы к падению производительности при работе с массивами и 
//существенной путанице.
//Работая на языках, поддерживающих создание конструкторов по умолчанию, их объявлять все равно 
//не стоит по тем же причинам, по которым они запрещены в большинстве языков платформы .NET.
//Значимые типы не так просты как кажется: помимо проблем с изменяемостью (мутабельностью)
//у значимых типов даже с конструкторами по умолчанию и то не все просто.

#endregion

public class SomeClass 
{
	public int x = 1, y = 2;
	public string s;
}

public struct SomeStruct
{
	public int x, y;
	//public int x = 1, y = 2;
	public string s;

	//В спецификации языка C# сказано, что пользователю запрещается
	//создавать конструктор по умолчанию явно, поскольку любая структура
	//содержит его неявно

//	public SomeStruct(int x, int y)
//	{
//		this.x = x;
//		this.y = y;
//		this.s = null;
//	}

	public SomeStruct(int x, int y) //: this()
	{
		this.x = x; 
		this.y = y; 
		this.s = null;
	}
}

static void Main()
{
	SomeClass c = new SomeClass();
	c.Dump();
	
	SomeStruct p1 = new SomeStruct ();  //Не вызывается     // p1.x and p1.y will be 0
	p1.Dump();
	
	SomeStruct p2 = default(SomeStruct);//Не вызывается
	p2.Dump();
	
	SomeStruct p3 = new SomeStruct (1, 1); //Вызывается  // p1.x and p1.y will be 1
	p3.Dump();
	
	DateTime dt = new DateTime();//Не вызывается
	dt.Dump();
}