<Query Kind="Statements" />

// When T? is boxed, the boxed value on the heap contains T, not T?.
// C# also permits the unboxing of nullable types with the as operator:

object o1 = 6;
int? x1 = o1 as int?;
(x1.HasValue).Dump();   // True
x1.Dump();