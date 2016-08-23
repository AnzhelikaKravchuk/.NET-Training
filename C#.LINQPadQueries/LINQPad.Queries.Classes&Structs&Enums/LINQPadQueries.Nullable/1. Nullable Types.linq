<Query Kind="Statements" />

// To represent null in a value type, you must use a special construct called a nullable type:
{
	int? i = null;                     // Nullable Type
	(i == null).Dump();     // True
	i = 9;
	i.GetType().Dump();
}
// Equivalent to:
{
	Nullable<int> i = new Nullable<int>();
	(!i.HasValue).Dump();           // True
	
	i = 23;
	i.Value.Dump();
}