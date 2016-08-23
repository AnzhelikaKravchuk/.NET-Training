<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//асинхронная операция выполняет свою работу после возврата управления вызывающему коду
//синхронная - перед
//Ключевые слова async и await позволяют писать асинхронный код, 
//обладающий той же структурой и простотой, что и синхронный,
//устраняя при этом необходимость написания кода, присущего
//асинхронному программирования

//	var result = await expression;
//	statement(s);

//	var awaiter = expression.GetAwaiter();
//	awaiter.OnCompleted (() => statement(s););

void Main()
{
	DisplayPrimesCount();
	//TODO
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}

//Асинхронные методы предназначены для использования в качестве
//неблокирующих операций.
async void DisplayPrimesCount()
{
	int result = await GetPrimesCountAsync (2, 1000000);
	//Выражение await в асинхронном методе не блокирует текущий поток 
	//на время выполнения ожидаемой задачи. Вместо этого, выражение
	//регистрирует остальную часть метода как продолжение и возвращает
	//управление вызывающему объекту асинхронного метода.
	Console.WriteLine (result);
}

//Ключевые слова async и await не вызывают создание дополнительных потоков.
//Асинхронные методы не требуют многопоточности, поскольку асинхронный 
//метод не выполняется в своем собственном потоке.
//Метод выполняется в текущем контексте синхронизации и использует время 
//в потоке, только когда метод активен
Task<int> GetPrimesCountAsync (int start, int count)
{
	return Task.Run (() =>
		ParallelEnumerable.Range (start, count).Count (n => 
			Enumerable.Range (2, (int)Math.Sqrt(n)-1).All (i => n % i > 0)));
}