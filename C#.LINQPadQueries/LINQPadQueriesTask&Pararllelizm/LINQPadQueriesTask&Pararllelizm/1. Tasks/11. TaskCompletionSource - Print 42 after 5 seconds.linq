<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var tcs = new TaskCompletionSource<int>();
tcs.Dump();
new Thread (() => { Thread.Sleep (5000); tcs.SetResult (42); }).Start();

Task<int> task = tcs.Task;         // Our "slave" task.
Console.WriteLine (task.Result);   // 42

//It works by giving you a "slave" task that you manually
//drive — by indicating when the operation finishes or faults

//public class TaskCompletionSource<TResult>
//{
//public void SetResult (TResult result);
//public void SetException (Exception exception);
//public void SetCanceled();
//public bool TrySetResult (TResult result);
//public bool TrySetException (Exception exception);
//public bool TrySetCanceled();
//...
//}
//Calling any of these methods signals the task, putting it into 
//a completed, faulted or canceled state

//You’re supposed to call one of these methods exactly once: if
//called again, SetResult, SetException, or SetCanceled will throw 
//an exception, whereas the Try* methods return false.
