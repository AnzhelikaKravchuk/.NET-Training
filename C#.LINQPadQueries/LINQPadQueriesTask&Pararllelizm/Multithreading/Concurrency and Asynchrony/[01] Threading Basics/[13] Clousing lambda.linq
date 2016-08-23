<Query Kind="Program" />

class ThreadTest
{
	bool upper;

	static void Main()
	{
		ThreadTest instance1 = new ThreadTest();
		instance1.upper = true;
		Thread t = new Thread(instance1.Go);
		t.Start();
		ThreadTest instance2 = new ThreadTest();
		instance2.Go();  // Запуск в главном потоке - с upper=false
	}

	void Go()
	{
		Console.WriteLine(upper ? "HELLO!" : "hello!");
	}
}