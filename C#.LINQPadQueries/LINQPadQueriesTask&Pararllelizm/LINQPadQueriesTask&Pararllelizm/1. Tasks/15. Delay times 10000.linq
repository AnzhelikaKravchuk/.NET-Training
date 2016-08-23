<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	for (int i = 0; i < 10000; i++)
		Delay (5000).GetAwaiter().OnCompleted (() => Console.WriteLine (42));
}

Task Delay (int milliseconds)
{
	var tcs = new TaskCompletionSource<object>();
	var timer = new System.Timers.Timer (milliseconds) { AutoReset = false };
	timer.Elapsed += delegate { timer.Dispose(); tcs.SetResult (null); };
	timer.Start();
	return tcs.Task;
}

//Таймеры инициируют свои обратные вызовы на потоках из пула потоков
//Спусти 5 сек пул потоков получит 10000 запросов на вызов метода SetResult
//Если эти запросы поступают быстре, чем они могут быть обработаны,
//пул потоков треагирует постановкой из в очередь и последующей обработкой
//на оптимальном уровне параллелизма для цп (идеально для кратковременных заданий)