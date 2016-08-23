<Query Kind="Program" />

// Возможность построить один делегат, который может указывать на методы,
// возвращающие типы классов, связанные классическим наследованием (не value type)
// Ковариация позволяет методу иметь тип возвращаемого значения, 
// степень наследования которого больше, чем указано в делегате
// Ковариация (ковариантность)
// Relax delegates
delegate object ObjectRetriever();
//delegate object D(string s);
//static object F1(object o){return o;}
//static string F2(string s){return s;}
static void Main()
{
//	D d = F1;
//	d += F2;

	ObjectRetriever o = new ObjectRetriever(RetriveString);
	object result = o();
	Console.WriteLine (result);
}

static string RetriveString() { return "return string"; }
//static int RetriveInteger() { return "return int"; }