<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//Unlike with threads, tasks conveniently propagate exceptions. 
//So, if the code in your task throws an unhandled exception 
//(in other words, if your task faults), that exception
//is automatically re-thrown to whoever calls Wait()— or accesses the
//Result property of a Task<TResult>:

// Start a Task that throws a NullReferenceException:

Task task = Task.Run (() => { throw null; });
try 
{
	task.Wait();
}
catch (AggregateException aex)
{
	aex.Dump();
}