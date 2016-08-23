<Query Kind="Program" />

void Main()
{	
	int x = 78;
	IFormattable ft = x;
	ft.Dump();
	ValueType vt = x;
	vt.Dump();
	object obj = x;
	obj.Dump();
	//Bar(42);
}

static int Bar(object value) 
{
	int a = (int)value;
	return a;
}