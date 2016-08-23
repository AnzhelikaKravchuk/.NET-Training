<Query Kind="Program" />

void Write (IEnumerable<object> a)
{
	a.Dump();
}

class Animal {}
class Dog : Animal {}

void Main()
{
	Write (new List<string> { "foo" } );
	//Write (new List<int>    { 12345 } );
}


//Assuming A is convertible to B, X is covariant if X<A> is convertible to X<B>.
//With C#’s notion of covariance (and contravariance), “convertible”
//means convertible via an implicit reference conversion - 
//such as A subclassing B, or A implementing B. Numeric
//conversions, boxing conversions, and custom conversions are
//not included.
