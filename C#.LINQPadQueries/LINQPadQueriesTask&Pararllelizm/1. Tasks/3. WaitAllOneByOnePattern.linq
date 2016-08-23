<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Threading.Tasks.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Для того, чтобы использовать таски более продуктивно, например, 
//на многопроцессорной машине, для выделения на каждую задачу 
//отдельного процесса используют паттерн WailAllOneByOne. 
//Его особенность в том, чтобы вместо метода Task.WaitAll, 
//использовать метод Task.WaitAny. 

var tasks = new List<System.Threading.Tasks.Task>();
//Количество создаваемых задач
int taskCount = 100;

var numberCores = Environment.ProcessorCount;
for (int i = 0; i < numberCores; i++)
{
	var task = System.Threading.Tasks.Task.Factory.StartNew(
						() => { Console.WriteLine(i); },
						System.Threading.Tasks.TaskCreationOptions.LongRunning);
	tasks.Add(task);
}

while (tasks.Count > 0)
{
	int index = System.Threading.Tasks.Task.WaitAny(tasks.ToArray());
	tasks.RemoveAt(index);

	taskCount--;

	if (taskCount > 0)
	{
		var task = System.Threading.Tasks.Task.Factory.StartNew(() => { Console.WriteLine(taskCount); },
				System.Threading.Tasks.TaskCreationOptions.LongRunning);
		tasks.Add(task);
	}
}