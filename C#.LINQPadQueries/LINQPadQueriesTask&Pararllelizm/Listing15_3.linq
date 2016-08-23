<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

void Main()
{
	
}
//The awaitable pattern (шаблон ожидания)
//a-la foreach & LINQ :) yeild & IEnumerable & IEnumerator

//The C# compiler does require the awaiter to implement INotifyCompletion. 
//This is primarily for efficiency reasons; some prerelease versions of the 
//compiler didn’t have the interface at all.

//

// Real interface in System.Runtime.CompilerServices 
public interface INotifyCompletion
{
	void OnCompleted(Action continuation);
}

// Warning: these don't really exist
// Imaginary interfaces for asynchronous operations returning values
public interface IAwaitable<T>
{
	IAwaiter<T> GetAwaiter();
}
public interface IAwaiter<T> : INotifyCompletion
{
	bool IsCompleted { get; }
	T GetResult();
	// Inherited from INotifyCompletion
	// void OnCompleted(Action continuation);
}
// Imaginary interfaces for "void" asynchronous operations
public interface IAwaitable
{
	IAwaiter GetAwaiter();
}
public interface IAwaiter : INotifyCompletion
{
	bool IsCompleted { get; }
	void GetResult();
	// Inherited from INotifyCompletion
	// void OnCompleted(Action continuation);
}

//One important point to note is that because both Task and Task<TResult> 
//implement the awaitable pattern, you can call one async method
//from another, and so on:
public async Task<int> FooAsync()
{
	string bar = await BarAsync();
	// Obviously this would usually be more complicated...
	return bar.Length;
}

public async Task<string> BarAsync()
{
	// Some async code that could call more async methods...
}


string pageText = await new HttpClient().GetStringAsync(url);
//vs
Task<string> task = new HttpClient().GetStringAsync(url); 
string pageText = await task;