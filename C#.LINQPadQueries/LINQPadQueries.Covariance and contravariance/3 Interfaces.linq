<Query Kind="Program" />

// если тип А может быть преобразован (неявное ссылочное преобразование в C#)
// в тип В (в C# А является подклассом В или А реализует В)
// то тип Х является ковариантным, если Х<А> может быть преобразован в Х<В>

//Ковариация(ковариантность) безопасна только тогда, когда тип описывает  
//только те операции, которые возвращают параметры типа

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

void Write(IEnumerable<Animal> animals)
{
	foreach (var t in animals)
	{
		t.Dump();//не изменяем входящие данные!
	}
}

void Main()
{
	Write (new List<Animal> { new Animal(), new Animal() } );	
	Write (new List<Cat>    { new Cat(), new Cat() } );	
	Write (new List<Dog>    { new Dog(), new Dog() } );
	IEnumerable<Dog> g = new List<Dog>();
	IEnumerable<Animal> f = g; //<--ковариация
	IEnumerable<Animal> f1 = new List<Dog>(); //<--ковариация
}