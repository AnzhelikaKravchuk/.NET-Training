<Query Kind="Program" />

// если тип А может быть преобразован (неявное ссылочное 
//преобразование в C#)
// в тип В (в C# А является подклассом В или А реализует В)
// то тип Х является ковариантным, если Х<А> может быть преобразован 
//в Х<В>
// то тип Х является контравариантным, если Х<B> может 
//быть преобразован в Х<A>

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

void Write (Animal[] animals)//массивы ковариантны
{
	foreach(var a in animals)
		a.Dump();
	//animals[0] = new Dog();
}

void Main()
{
	Write (new Animal[] { new Animal(), new Animal() } );	
	Write (new Cat[]    { new Cat(), new Cat()    } );	
	Write (new Dog[]    { new Dog(), new Dog()    } );	
}