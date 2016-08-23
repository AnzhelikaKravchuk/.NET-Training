<Query Kind="Program" />

//Класс Mutex очень похож на класс Monitor. 
//Отличие (поверхностные)заключается в том, что Monitor является static классом, 
//а Mutex нет. Для входа в критическую секцию у Mutex используется метод 
//WaitOne, для освобождения метод Releasemutex

static int value = 0;

static Mutex mut = new Mutex();

static void Inc()
{
	for (int i = 0; i < 1000000; i++)
	{
		mut.WaitOne();
		value = value + 1;
		mut.ReleaseMutex();
	}
}

static void Dec()
{
	for (int i = 0; i < 1000000; i++)
	{
		mut.WaitOne();
		value = value - 1;
		mut.ReleaseMutex();
	}
}

//намного медленнее!!!
//главном отличии Mutex и Monitor: Mutex можно использовать для синхронизации 
//между процессами. Т.е. если создать Mutex и присвоить ему строковое имя 
//(есть такая версия перегруженного конструктора), 
//он будет доступен всем процессам запущенным на компьютере

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