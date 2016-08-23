<Query Kind="Program" />

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

void Write<T>(List<T> animals) where T: Animal 
{
	foreach(var a in animals)
		a.Dump();
		//animals[0]=(T)(object)(new Dog());
}

void Main()
{
	Write (new List<Animal> { new Animal(), new Animal() } );	
	Write (new List<Cat>    { new Cat(), new Cat() } );	
	Write (new List<Dog>    { new Dog(), new Dog() } );	
}