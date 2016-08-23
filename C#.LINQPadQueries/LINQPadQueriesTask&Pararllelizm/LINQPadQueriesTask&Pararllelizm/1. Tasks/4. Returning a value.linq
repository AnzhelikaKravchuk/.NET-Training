<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task<int> task = Task.Run (() => 
		{ 
			Console.WriteLine ("Foo"); 
			Thread.Sleep(5000); 
			return 3; 
		});

int result = task.Result;      // Blocks if not already finished
Console.WriteLine (result);    // 3