<Query Kind="Program" />

// Более общее решение предусматривает преведение вначале к object, 
// этот подход работает, т.к. предполагается, что преобразование в/из object
// должны быть не специальными, а ссылочными или упаковочными/распаковочными
// преобразованиями. В данном случае StringBuilder является ссылочным типом, 
// поэтому должно происходить ссылочное преобразование

StringBuilder Foo<T> (T arg)
{
	if (arg is StringBuilder)
		return (StringBuilder) (object) arg;
	
	/*...*/
	return null;
}

static void Main()
{
}