<Query Kind="Statements" />

// A lambda expression can reference the local variables and parameters of the method
// in which it’s defined (outer variables)

int factor = 2;
Func<int, int> multiplier = n => n * factor;
Console.WriteLine (multiplier (3));           // 6

// Captured variables are evaluated when the delegate is invoked, not when the variables were captured:

factor = 10;
Console.WriteLine (multiplier (3));           // 30

// Lambda expressions can themselves update captured variables:

int seed = 0;
Func<int> natural = () => seed++;
Console.WriteLine (natural());           // 0
Console.WriteLine (natural());           // 1
Console.WriteLine (seed);                // 2