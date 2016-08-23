<Query Kind="Program" />

//Run-time evaluation of argument lists 
//During the run-time processing of a function member invocation (§7.5.4),
//the expressions or variable references of an argument list are 
//evaluated in order from left to right

void Main()
{
	int i = 5;
	Console.WriteLine(i);
	Write(PreficsIncr(ref i), PostficsIncr(ref i));
	i = 5;
	Console.WriteLine(i);
	Write(b: PreficsIncr(ref i), a: PostficsIncr(ref i));
}

public static void Write(int a, int b) 
{
    Console.WriteLine("{0} {1}", a, b);
}

public static int PreficsIncr(ref int i) 
{
    Console.WriteLine("first");
	++i;
	return ++i;
}

public static int PostficsIncr(ref int i)
{
    Console.WriteLine("second");
	i++;
    return i++;
}