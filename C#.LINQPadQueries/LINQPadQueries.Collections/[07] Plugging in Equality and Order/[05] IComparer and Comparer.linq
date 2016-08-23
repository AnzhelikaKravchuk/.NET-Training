<Query Kind="Program" />

public interface IComparer
{
    int Compare(object x, object y);
}

public interface IComparer <in T>
{
    int Compare(T x, T y);
}

public abstract class Comparer<T> : IComparer, IComparer<T>
{
    public static Comparer<T> Default { get; }
	
	public abstract int Compare (T x, T y); // Implemented by you
	int IComparer.Compare (object x, object y); // Implemented for you 
}

class Wish
{
	public string Name;
	public int Priority;

	public Wish (string name, int priority)
	{
		Name = name;
		Priority = priority;
	}
}

class PriorityComparer : Comparer <Wish>
{
	public override int Compare (Wish x, Wish y)
	{
		if (object.Equals (x, y)) return 0;          // Fail-safe check
		return x.Priority.CompareTo (y.Priority);
	}
}

void Main()
{
	var wishList = new List<Wish>();
	wishList.Add (new Wish ("Peace", 2));
	wishList.Add (new Wish ("Wealth", 3));
	wishList.Add (new Wish ("Love", 2));
	wishList.Add (new Wish ("3 more wishes", 1));
	
	wishList.Sort (new PriorityComparer());
	wishList.Dump();
}