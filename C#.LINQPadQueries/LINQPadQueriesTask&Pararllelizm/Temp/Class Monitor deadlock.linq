<Query Kind="Program" />

//как можно попробовать бороться с тупиками при помощи Monitor

//метод Inc. отличается от метода Dec тем, что захватив секцию А, 
//он не просто пытается захватить секцию B, а делает это с проверкой: 
//получилось или нет. Если получилось, то идет обычное выполнение. 
//Если не получилось, то мы освобождаем ненадолго блокировку секции А, 
//потом ее опять захватываем и снова проверяем получается ли захватить секцию B.

static int valueA = 0;
static int valueB = 0;

static object mySectionA = new object();
static object mySectionB = new object();

static void Inc()
{
	for (int i = 0; i < 1000000; i++)
	{
		Monitor.Enter(mySectionA);
		valueA = valueA + 1;
		while (!Monitor.TryEnter(mySectionB))
		{
			Monitor.Wait(mySectionA, 10);
		}
		valueB = valueB - 1;
		Monitor.Exit(mySectionB);
		Monitor.Exit(mySectionA);
	}
}

static void Dec()
{
	for (int i = 0; i < 1000000; i++)
	{
		Monitor.Enter(mySectionB);
		valueB = valueB + 1;
		Monitor.Enter(mySectionA);
		valueA = valueA - 1;
		Monitor.Exit(mySectionA);
		Monitor.Exit(mySectionB);
	}
}

static void Main()
{
	Thread inc = new Thread(new ThreadStart(Inc));
	Thread dec = new Thread(new ThreadStart(Dec));
	inc.Start();
	dec.Start();
	inc.Join();
	dec.Join();
	value.Dump("value = ");
}