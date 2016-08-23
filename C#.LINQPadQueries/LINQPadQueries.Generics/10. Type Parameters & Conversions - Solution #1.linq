<Query Kind="Program" />

// Простейшим решением будет использование вместо этого операции as, 
// которая не дает неоднозначности по скольку она не позволяет 
// осуществлять специальные преобразования

StringBuilder Foo<T> (T arg)
{
	StringBuilder sb = arg as StringBuilder;
	if (sb != null) return sb;
	
	/*...*/
	return null;
}

static void Main()
{
}