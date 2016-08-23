<Query Kind="Program" />

	static int value = 0; 

	static AutoResetEvent five = null;
	static AutoResetEvent zero = null;  

	static void Inc()
	{
		// Перед запуском ждем, чтобы нам сообщили,
		// что в переменной 0
		zero.WaitOne();
		for (int i = 0; i < 10; i++)
		{
			if (value == 5)
			{
				// Сообщаем, что достигли 5
				five.Set();
				// Ждем ноля
				zero.WaitOne();
			}
			value = value + 1;
			Console.WriteLine(value);
		}
	} 

	static void Dec()
	{
		// Перед запуском ждем, чтобы нам сообщили,
		// что в переменной 5
		five.WaitOne();
		for (int i = 0; i < 10; i++)
		{
			if (value == 0)
			{
				// Сообщаем, что достигли 0
				zero.Set();
				// Ждем 5
				five.WaitOne();
			}
			value = value - 1;
			Console.WriteLine(value);
		}
	} 

	static void Main()
	{
		Thread inc = new Thread(Inc);
		Thread dec = new Thread(Dec);
		five = new AutoResetEvent(false); // Событие не активно
		zero = new AutoResetEvent(true); // т.к. в value ноль, поднимаем событие
		inc.Start();
		dec.Start();
		inc.Join();
		dec.Join();
		value.Dump("Значение по окончании:");
	}