<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <GACReference>System.Threading.Tasks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a</GACReference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
			Console.WriteLine("foreground thread starts.");
			System.Threading.Tasks.Task task = System.Threading.Tasks.Task.Run(new Action(CustomTask));
			var awaiter = task.GetAwaiter();
			awaiter.OnCompleted (() => 
			{
				//int result = awaiter.GetResult();
				Console.WriteLine ("continuation finished!");       // Writes result
			});

            for (int i =0; i < 60; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            } 

			Console.WriteLine("foreground thread finished.");

}

		static void CustomTask()
		{
			Console.WriteLine("Task works.");

			for (int count = 0; count < 20; count++)
			{
				Thread.Sleep(500);
				Console.WriteLine("task counter: " + count);
			}

			Console.WriteLine("Task finished.");
		}