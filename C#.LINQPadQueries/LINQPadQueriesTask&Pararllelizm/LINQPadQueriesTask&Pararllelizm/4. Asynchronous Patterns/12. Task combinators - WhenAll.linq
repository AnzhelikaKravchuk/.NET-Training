<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

// Комбинатор задач Task.WhenAll завершится, когда завершатся все переданные
//ему задачи
//demonstrates the fork/join pattern (ветвления/присоединения)
async void Main()
{
	var task = Task.WhenAll (Delay1(), Delay2(), Delay3());
	await task.Dump();
	"Done".Dump();
}

async Task<int> Delay1() { await Task.Delay (1000); return 1; }
async Task<int> Delay2() { await Task.Delay (2000); return 2; }
async Task<int> Delay3() { await Task.Delay (3000); return 3; }