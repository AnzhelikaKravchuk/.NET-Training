<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
</Query>

//Если необходимо самостоятельно определить некоторые методы, 
//отсутствующие в классе StringBuilder  


// - нужно добавить к типу определенные члены
// - нет необходимости в добавлении каких-либо дополнительных данных к экхемплярам типа
// - нет возможности изменить сам тип, поскольку код его не доступен
void Main()
{
	StringBuilder sb = new StringBuilder("Hello, world.");
	
	// программный код не отражает последовательность операторов, 
	//представленных в объекте StringBuilder -  плохо для понимания, чтения и поддержки
	
	//Везде присутствует класс StringBuilderExtensions
	int index = StringBuilderExtensions.IndexOf(sb.Replace('.', '!'), '!');

	sb.Dump();
	index.Dump();
	//int index = sb.Replace('.', '!').IndexOf('!');!!!
}


//Первая проблема для программистов, желающих получить индекс
//символа при помощи класса StringBuilder - существование класса StringBuilderExtensions
public static class StringBuilderExtensions 
{
	public static int IndexOf(StringBuilder sb, char value) 
	{
		for (int index = 0; index < sb.Length; index++)
			if (sb[index] == value) return index;
		return -1;
	}
}