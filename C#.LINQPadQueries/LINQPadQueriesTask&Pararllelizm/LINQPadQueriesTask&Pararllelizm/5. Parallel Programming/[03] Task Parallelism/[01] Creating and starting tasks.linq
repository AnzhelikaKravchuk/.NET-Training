<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var task = Task.Run (() => Console.WriteLine ("Hello from a task!"));
task.Wait();	// Wait for task to finish