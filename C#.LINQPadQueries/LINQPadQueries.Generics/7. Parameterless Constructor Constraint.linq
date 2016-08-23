<Query Kind="Program">
  <Namespace>System.Runtime.Serialization</Namespace>
</Query>

// The parameterless constructor constraint requires T
// to have a public parameterless constructor.
// If this constraint is defined, you can call new() on T:

static void Initialize<T> (T[] array) where T : ISerializable, new()
{
	for (int i = 0; i < array.Length; i++)
		array[i] = new T();
}

static void Main()
{
	var builders = new StringBuilder[100];
	Initialize (builders);
	builders[37].Dump();
}