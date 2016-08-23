<Query Kind="Statements">
  <Reference>C:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.Numerics.dll</Reference>
</Query>

// создадим лямбду, чтобы вычислять факторал
Func<uint, System.Numerics.BigInteger> factorial = null;
factorial = n => (n == 0) ? 1 : n * factorial(n - 1);

// объект factorial определён в первом примере
// так как отслеживаем окончание работы методов,
// сохраняем результат вызова BeginInvoke()
IAsyncResult ar1 = factorial.BeginInvoke(8000, null, null);
IAsyncResult ar2 = factorial.BeginInvoke(1000, null, null);

Thread.Sleep(2000);
// получаем результат второго вызова и печатаем его
System.Numerics.BigInteger res1 = factorial.EndInvoke(ar2);
Console.WriteLine(res1);

// получаем результат первого вызова
System.Numerics.BigInteger res2 = factorial.EndInvoke(ar1);
Console.WriteLine(res2);

