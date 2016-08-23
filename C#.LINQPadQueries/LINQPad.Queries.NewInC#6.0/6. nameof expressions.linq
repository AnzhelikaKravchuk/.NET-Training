<Query Kind="Statements" />

//В C# 6.0 оператор nameof будет использоваться, 
//чтобы избежать появления в коде строковых литералов
//свойств. Этот оператор возвращает строковый литерал
//передаваемого в него элемента. В качестве параметра
//можно передать любой член класса или сам класс.

int? x = null;
try
{
	if (x == null) 
		throw new ArgumentNullException(nameof(x));
}
catch(ArgumentNullException ex)
{
	ex.Message.Dump();
}

string name = nameof(Console.WriteLine);
name.Dump();

//WriteLine(nameof(person.Address.ZipCode)); // prints "ZipCode"