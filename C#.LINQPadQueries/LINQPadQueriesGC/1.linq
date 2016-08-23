<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

//Энергичная сборка мусора
//Такое «нетерпение» по отношению к локальным корням в 
//действительности поддерживается динамическим компилятором 
//(Just-In-Time Compiler, JIT) среды выполнения.NET. 
//Сборщик мусора понятия не имеет, когда локальная переменная 
//выходит из употребления в пределах метода. Эта информация 
//записывается в специальные таблицы JIT-компилятором в процессе 
//компиляции метода. Для каждой локальной переменной JIT-компилятор 
//записывает в таблицу адрес самой первой и самой последней инструкции,
//где локальная переменная остается активным корнем. 
//Эта таблица используется сборщиком мусора в процессе обхода 
//ссылок на стеке. (Обратите внимание, что локальные переменные
//могут храниться не только в стеке, но и в регистрах процессора,
//и таблицы JIT-компилятора должны содержать информацию об этом.)


public static void Main() 
{
	Timer t = new Timer(TimerCallback,null,0,1000);
  	Thread.Sleep(3000);
	//t = null;
	//t.Dispose();
	//GC.KeepAlive(t);
//	using (var timer = new Timer(TimerCallback,null,0,200))
//	{
//		Thread.Sleep(3000);
//	}
}

private static void TimerCallback(Object o) 
{
    Console.WriteLine("In TimerCallback: " + DateTime.Now);
    GC.Collect();
}