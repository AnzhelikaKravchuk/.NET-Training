<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task task = Task.Run (() =>
{
	Console.WriteLine ("Task started");
	Thread.Sleep (2000);
	Console.WriteLine ("Foo");
});

task.Wait();  // Blocks until task is complete
task.Dump("task");
Console.WriteLine (task.IsCompleted);  // True
Console.WriteLine (task.IsFaulted);  // False

Action work = () =>
                  {
                      Thread.Sleep(2000);
                      Console.WriteLine("Done");
                  };

Task task = new Task(work);
task.RunSynchronously();
//task.Start();
