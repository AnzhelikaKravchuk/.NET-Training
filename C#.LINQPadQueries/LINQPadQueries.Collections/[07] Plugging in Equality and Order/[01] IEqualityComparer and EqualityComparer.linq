<Query Kind="Program" />

public interface IEqualityComparer<T>
{
   bool Equals (T x, T y);
   int GetHashCode (T obj);
}

public interface IEqualityComparer
{
   bool Equals (object x, object y);
   int GetHashCode (object obj);
}

//Представляет базовый класс для реализаций универсального
//интерфейса IEqualityComparer<T>.
public abstract class EqualityComparer<T> : IEqualityComparer,
											IEqualityComparer<T>
{
	public abstract bool Equals (T x, T y);
	public abstract int GetHashCode (T obj);
	
	bool IEqualityComparer.Equals (object x, object y);
	int IEqualityComparer.GetHashCode (object obj);

    public static EqualityComparer<T> Default { get; }
}

public class Customer
{
	public string LastName;
	public string FirstName;

	public Customer (string last, string first)
	{
		LastName = last;
		FirstName = first;
	}
}
public class LastFirstEqComparer : EqualityComparer <Customer>
{
	public override bool Equals (Customer x, Customer y)
	{
		return x.LastName == y.LastName && x.FirstName == y.FirstName;
	}

	public override int GetHashCode (Customer obj)
	{
		return (obj.LastName + ";" + obj.FirstName).GetHashCode();
	}
}


void Main()
{
	Customer c1 = new Customer ("Bloggs", "Joe");
	Customer c2 = new Customer ("Bloggs", "Joe");
	
	Console.WriteLine (c1 == c2);               // False
	Console.WriteLine (c1.Equals (c2));         // False
	
	var d = new Dictionary<Customer, string>();
	d [c1] = "Joe";
	Console.WriteLine (d.ContainsKey (c2));         // False

	var eqComparer = new LastFirstEqComparer();
	d = new Dictionary<Customer, string> (eqComparer);
	d [c1] = "Joe";
	Console.WriteLine (d.ContainsKey (c2));         // True
}