<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Task.Run (() => Console.WriteLine ("Foo"));//  <-.NET Framework 4.5

Task.Factory.StartNew(() => Console.WriteLine ("Foo"));
//Tasks use pooled threads by default, which are background threads

new Thread (() => Console.WriteLine ("Foo")).Start();
//We didn’t call Start because Task.Run creates "hot" tasks;
//you can instead use Task’s constructor to create "cold" tasks 
//although this is rarely done in practice