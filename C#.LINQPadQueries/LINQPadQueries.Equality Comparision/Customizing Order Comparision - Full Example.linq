<Query Kind="Program" />

public struct Note : IComparable<Note>, IEquatable<Note>, IComparable
{
	int _semitonesFromA;
	public int SemitonesFromA { get { return _semitonesFromA; } }
	
	public Note (int semitonesFromA)
	{
		_semitonesFromA = semitonesFromA;
	}
	
	public int CompareTo (Note other)            // Generic IComparable<T>
	{
		if (Equals (other)) return 0;    // Fail-safe check
		return _semitonesFromA.CompareTo (other._semitonesFromA);
	}
	
	int IComparable.CompareTo (object other)     // Nongeneric IComparable
	{
		if (!(other is Note))
			throw new InvalidOperationException ("CompareTo: Not a note");
		return CompareTo ((Note) other);
	}
	
	public static bool operator < (Note n1, Note n2)
	{
		return n1.CompareTo (n2) < 0;
	}
	
	public static bool operator > (Note n1, Note n2)
	{
		return n1.CompareTo (n2) > 0;
	}
	
	public bool Equals (Note other)    // for IEquatable<Note>
	{
		return _semitonesFromA == other._semitonesFromA;
	}
	
	public override bool Equals (object other)
	{
		if (!(other is Note)) return false;
		return Equals ((Note) other);
	}
	
	//алгоритм хеширования изменился использует 
	//manage идентификатор потока, в котором 
	//выполняется метод
	public override int GetHashCode()
	{
		return _semitonesFromA.GetHashCode();
	}
	
	public static bool operator == (Note n1, Note n2)
	{
		return n1.Equals (n2);
	}
	
	public static bool operator != (Note n1, Note n2)
	{
		return !(n1 == n2);
	}
}

static void Main()
{
	Note n1 = new Note (1);	
	Note n2 = new Note (2);
	(n2 > n1).Dump();
}