<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <Namespace>System.Dynamic</Namespace>
</Query>

dynamic expando = new ExpandoObject();
expando.SampleProperty =   "This property was added at run time";
expando.SampleMethod = (Action)(() => Console.WriteLine(expando.SampleProperty));
expando.SampleMethod();
((IDictionary<string,object>)expando).Dump();