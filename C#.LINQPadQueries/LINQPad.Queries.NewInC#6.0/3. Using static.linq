<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\mscorlib.dll</Reference>
  <Namespace>System.Linq.Enumerable</Namespace>
</Query>

//using static System.Console; 
//using static System.Math;
//using static System.Linq.Enumerable;
//look example VS2015
class Program
{
    static void Main()
    {
        //WriteLine(Sqrt(3*3 + 4*4));
		//Extension methods
		//public static IEnumerable<int> Range(int start,int count)
		var range = System.Linq.Enumerable.Range(5, 17); // Ok: not extension 
		//var odd = Where(range, i => i % 2 == 1); // Error, not in scope
		var even = range.Where(i => i % 2 == 0); // Ok
	}
}