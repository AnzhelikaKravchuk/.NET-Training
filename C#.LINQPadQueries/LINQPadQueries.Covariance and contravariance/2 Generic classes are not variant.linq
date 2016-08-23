<Query Kind="Program" />

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

void Write(List<Animal> animals)
{
	foreach(var a in animals)
		a.Dump();
}

void Main()
{
	List<Animal> animals = new List<UserQuery.Animal>();
	animals.Add(new Animal());
	animals.Add(new Cat());
	animals.Add(new Dog());
	Write(animals);
//	Write (new List<Animal> { new Animal(), new Animal() } );	
//	Write (new List<Cat>    { new Cat(), new Cat() } );	
//	Write (new List<Dog>    { new Dog(), new Dog() } );	
}