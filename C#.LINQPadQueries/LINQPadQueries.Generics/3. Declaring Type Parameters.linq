<Query Kind="Program" />

// Type parameters can be introduced in the declaration of 
//classes, structs, interfaces, delegates and methods!!!

//using CustomDictionary = System.Collections.Generic.Dictionary<int,string>;

static void Swap<T>(ref T a, ref T b)
{
	T temp = a;
	a = b;
	b = temp;
}

static void Swap<T,T1>(ref T a, ref T b)
{
	T temp = a;
	a = b;
	b = temp;
}

struct Nullable<T>
{
	public T Value { get; set; }
}

// A generic type or method can have multiple parameters:
class Dictionary<TKey, TValue> { /*...*/ }

interface SomeInterface<T> { }

// Generic type names and method names can be overloaded as long as
//the number of type parameters is different:
class A<T> { }
class A<T1, T2> { }

static void Display(String s)
{
	"Display(string):".Dump();
	Console.WriteLine(s);
}

static void Display<T>(T o)
{
	"Display(generic):".Dump();
	Display(o.ToString());
}

static void Main()
{
	// To instantiate:
	Dictionary<int, string> myDic = new Dictionary<int, string>();
	// Or:
	var myDicEasy = new Dictionary<int, string>();

	int x = 5;
	int y = 10;
	Swap(ref x, ref y);

	#region 1
	//Спецификация C# гласит, что когда у вас есть выбор между 
	//ReallyDoIt<string>(string) и ReallyDoIt(string) – то есть,
	//когда выбор идет из двух методов с идентичными сигнатурами,
	//но один из них получает эту сигнатуру после подстановки 
	//обобщённых параметров – тогда мы выбираем «натуральную» 
	//сигнатуру вместо «подстановленной»
	#endregion
	Display("Hello");
	Display(123);
	Display<string>("Hello");

	//	Type a1 = typeof (A<>);
	//	a1.Dump();//арность(arity)типа, то есть число необходимых для него параметров типа
	//	Type a2 = typeof (A<,>);  // Use commas to indicate multiple type args.
	//	a2.Dump();
	//	// You can also use the typeof operator to specify a closed type:
	//	Type a3 = typeof (A<int,int>);
	//	a3.Dump();
}