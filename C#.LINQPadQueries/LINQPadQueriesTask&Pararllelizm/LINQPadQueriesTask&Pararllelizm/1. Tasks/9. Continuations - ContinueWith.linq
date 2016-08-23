<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Второй способ присоединения продолжения 
Task<int> primeNumberTask = Task.Run (() =>
	Enumerable
	.Range (2, 3000000)
	.Count (n => Enumerable.Range (2, (int)Math.Sqrt(n)-1)
						   .All (i => n % i > 0)));

primeNumberTask.ContinueWith (antecedent => 
{
	int result = antecedent.Result;
	Console.WriteLine (result);          // Writes 216816
});