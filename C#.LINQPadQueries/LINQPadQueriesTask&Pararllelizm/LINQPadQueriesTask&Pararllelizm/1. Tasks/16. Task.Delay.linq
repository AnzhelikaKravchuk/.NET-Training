<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//The Delay method that we just wrote is sufficiently useful that it’s available as a static
//method on the Task class:
Task.Delay (5000).GetAwaiter().OnCompleted (() => Console.WriteLine (42));

// Another way to attach a continuation:
Task.Delay (5000).ContinueWith (ant => Console.WriteLine (42));