<Query Kind="Program" />

void Main() 
{
	var worker = new Thread(() => 
						{
							Console.WriteLine("Worker thread - Hello!");
						});
	Console.WriteLine("Main thread - Press ENTER to start worker"); 
	Console.ReadLine();
	//операция с которая тратит большую часть времени на ожидание
	//операция с интенcивным вводом-выводом (Thread.Sleep Thread.Join)
	//на время ожидания поток блокируется
	//заблокированный поток немедленно возвращает свой квант процессорного
	//времени и не потребляет процессорное время до тех пор, пока
	//не нарушится условие блокировки
	//при блокировке или деблокировке ОС выполняется переключение контекста
	//противоположность - операции с интенсивными вычислениями -
	//большая часть времени на вычисления с привлечением цт
	worker.Start();
	Console.WriteLine("Main thread - Worker started"); 
	Console.WriteLine("Main thread - Press ENTER to quit");
	Console.ReadLine();
}