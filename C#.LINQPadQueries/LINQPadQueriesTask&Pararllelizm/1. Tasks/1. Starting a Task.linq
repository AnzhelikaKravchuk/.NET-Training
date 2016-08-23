<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Tasks use pooled threads by default, which are background threads
//you can instead use Task’s constructor to create "cold" tasks 
//although this is rarely done in practice
var task = new Task(() => 
					{ 
						Thread.Sleep(1000);
						Console.WriteLine ("Task works!"); 
					}); 
//task.Id.Dump();
task.Status.Dump("Status");
task.Start();
task.Status.Dump("Status");

ThreadPool.QueueUserWorkItem((notused) => Console.WriteLine ("Thread pool thread works!"));
new Thread (() => Console.WriteLine ("Thread works!")).Start();

Task.Factory.StartNew(() => Console.WriteLine ("Factory task works!"));
Task.Run (() => Console.WriteLine ("Hot task works!"));//  <-.NET Framework 4
//We didn’t call Start because Task.Run creates "hot" tasks;