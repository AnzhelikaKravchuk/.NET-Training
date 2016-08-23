<Query Kind="Program" />

//Метод Exchange принимает два параметра. 
//В качестве первого по ссылке переменную, значение которой необходимо заменить.
//В качестве второго параметра, по значению, то, чем необходимо заменить.
//Метод возвращает значение, которое было в первом параметре до замены. 


//Аналог конструкции lock.
//Алгоритм:
//1. Вводим дополнительную переменную, которая будет хранить 0, 
//если наш аналог кретической секции свободен.
//2. Пытаемся записать в нашу переменную 1, с проверкой, какое 
//значение в ней было ранее. Если и ранее в переменной было 1, то ждем и выполняем этот пункт еще раз. Если в переменной был до присвоения 0, то переходим к шагу 3.
//3. Делаем полезную работу.
//4. Присваиваем в переменную 0.
static int lockVariable = 0;

static void MyLock(Action action)
{
	// Присвоение в переменную 1, с проверкой, что в не было ранее
	while (1 == Interlocked.Exchange(ref lockVariable, 1))
	{
		// Если была 1, то ждем
		Thread.Sleep(10);
	}
	// Полезная работа
	action();
	// Освобождаем секцию записав в переменную 0
	Interlocked.Exchange(ref lockVariable, 0);
}

static int value = 0;

static void Inc()
{
	for (int i = 0; i < 1000000; i++)
	{
		MyLock(() => { value = value + 1; });
	}
}
 
static void Dec()
{
	for (int i = 0; i < 1000000; i++)
	{
		MyLock(() => { value = value - 1; });
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
