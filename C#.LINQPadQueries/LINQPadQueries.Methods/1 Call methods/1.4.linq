<Query Kind="Program" />

//https://en.wikipedia.org/wiki/List_of_CIL_instructions
void Main()
{
	int a = 1;
	Foo1(a);
	a.Dump();
	Foo(ref a);
	a.Dump();
}

void Foo(ref int a)
{
	a++;
}

void Foo1(int a)
{
	a++;
}

//ldind.i4 - Indirect load (косвенная загрузка) value of type int32 as int32 on the stack   
//stind.i4 - Store value of type int32 into memory at address (сохранение по адресу)