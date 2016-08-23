<Query Kind="Program" />

public delegate void Action<in T>(T obj);
public delegate T Func<out T>();

class Animal { }
class Dog : Animal { }
class Cat : Animal { }

void Main()
{
	Func<Dog> fd = () => new Dog();
	Func<Animal> fa = fd;
	fa = () => new Cat();
	fa().Dump();
	fa().Dump();

	Action<Animal> aa = (Animal a) => a.Dump();
	Action<Dog> ad = aa;
	ad(new Dog());

	Converter<object, string> converter = x => x.ToString();
	Converter<string, string> contravariance = converter;
	Converter<object, object> covariance = converter;
	Converter<string, object> both = converter;
}

void Foo(Animal a)
{
	a.Dump();
}

Cat F()
{
	return new Cat();
}
