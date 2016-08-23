<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

public interface IStructuralEquatable
{
    bool Equals (object other, IEqualityComparer comparer);
    int GetHashCode (IEqualityComparer comparer);
}

public interface IStructuralComparable
{
    int CompareTo (object other, IComparer comparer);
}

{
	int[] a1 = { 1, 2, 3 };
	int[] a2 = { 1, 2, 3 };
	IStructuralEquatable se1 = a1;
	Console.WriteLine (a1.Equals (a2));                                  // False
	Console.WriteLine (se1.Equals (a2, EqualityComparer<int>.Default));  // True
}
{
	string[] a1 = "the quick brown fox".Split();
	string[] a2 = "THE QUICK BROWN FOX".Split();
	IStructuralEquatable se1 = a1;
	bool isTrue = se1.Equals (a2, StringComparer.InvariantCultureIgnoreCase);
}
{
	var t1 = Tuple.Create (1, "foo");
	var t2 = Tuple.Create (1, "FOO");
	IStructuralEquatable se1 = t1;
	Console.WriteLine (se1.Equals (t2, StringComparer.InvariantCultureIgnoreCase));     // True
	IStructuralComparable sc1 = t1;
	Console.WriteLine (sc1.CompareTo (t2, StringComparer.InvariantCultureIgnoreCase));  // 0
}
{
	var t1 = Tuple.Create (1, "FOO");
	var t2 = Tuple.Create (1, "FOO");
	Console.WriteLine (t1.Equals (t2));   // True
}