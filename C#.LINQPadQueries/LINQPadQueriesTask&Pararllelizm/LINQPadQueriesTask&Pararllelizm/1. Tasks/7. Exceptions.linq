<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//With autonomous “set-and-forget” tasks (those for which you don’t 
//rendezvous via Wait() or Result, or a continuation that does the same), 
//it’s good practice to explicitly exception-handle the task code 
//to avoid silent failure, just as you would with a thread.

Task task = Task.Run(() => { throw new NullReferenceException(); });//CLR 4.5!