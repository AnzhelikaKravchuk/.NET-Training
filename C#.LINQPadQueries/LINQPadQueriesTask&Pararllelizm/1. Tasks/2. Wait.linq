<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task = Task.Run (() =>
{
	Console.WriteLine ("Task started");
	Thread.Sleep (2000);
	Console.WriteLine ("Task work");
});
task.Status.Dump("Status");
task.Wait();  // Blocks until task is complete
task.Status.Dump("Status");
task.Dump("task");
Console.WriteLine (task.IsCompleted);  // True
Console.WriteLine (task.IsFaulted);  // False

Action work = () =>
                  {
                      Thread.Sleep(2000);
                      Console.WriteLine("Done");
                  };

Task task1 = new Task(work);
task1.RunSynchronously();
//task1.Start();