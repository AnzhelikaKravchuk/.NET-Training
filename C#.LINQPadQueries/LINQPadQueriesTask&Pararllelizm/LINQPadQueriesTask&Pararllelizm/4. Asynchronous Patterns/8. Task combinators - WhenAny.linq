<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Существует возможность использования и написания комбинаторов задач - 
//функций, удобно объединяющих задачи, не принимая во внимание, что
//конкретно делает та или иная задача

//Среда CLR предоставляет два комбинатора Task.WhenAny и Task.WhenAll
//Task.WhenAny завершает задачу, которая завершатся при завершении любой
//из скомбинированных задач

async void Main()
{
	Task<int> winningTask = await Task.WhenAny (Delay1(), Delay2(), Delay3());
	Console.WriteLine ("Done");
	//Method is non-blocking—including the last line when we access the Result 
	//property (because winningTask will already have finished)
	Console.WriteLine (winningTask.Result);//1
}

async Task<int> Delay1() { await Task.Delay (1000); return 1; }
async Task<int> Delay2() { await Task.Delay (2000); return 2; }
async Task<int> Delay3() { await Task.Delay (3000); return 3; }