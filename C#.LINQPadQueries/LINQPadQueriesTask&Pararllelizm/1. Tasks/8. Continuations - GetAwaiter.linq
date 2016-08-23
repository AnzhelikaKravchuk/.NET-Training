<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//A continuation says to a task, "when you’ve finished, continue 
//by doing something else." A continuation is usually implemented by 
//a callback that executes once upon completion of an operation.

//Существует два способа присоединения продолжения задач
//нововведение .NET Framework 4.5 (используется асинхронными функциями C# 5.0)

Task<int> primeNumberTask = Task.Run (() => 
	Enumerable.Range (2, 3000000)
		      .Count (n => Enumerable.Range (2, (int)Math.Sqrt(n)-1)
			  					     .All (i => n % i > 0)));

var awaiter = primeNumberTask.GetAwaiter();
//Метод GetAwaiter возвращает объект ожидания (awaiter), метод OnCompleted
//которого сообщает задаче, что по ее завершению (или отказу)
//необходимо выполнить делегат
awaiter.OnCompleted (() => 
{
	int result = awaiter.GetResult();
	Console.WriteLine (result);       // Writes result
});

//Объект ожидания - это любой объект, открывающий методы GetResult и 
//OnCompleted и булевское свойство IsCompleted (нет интерфейса и базового класса!)
//OnCompleted - часть интерфейса INotifyCompletion