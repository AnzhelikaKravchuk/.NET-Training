<Query Kind="Program" />

static void Main() 
{
  	new Thread(Go).Start();      // Выполнить Go() в новом потоке
  	Go();                         // Выполнить Go() в главном потоке
}
 
static void Go() 
{
  	// Определяем и используем локальную переменную 'cycles'
  	for (int cycles = 0; cycles < 5; cycles++)
		Console.Write('?');
}