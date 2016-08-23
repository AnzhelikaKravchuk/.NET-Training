<Query Kind="Statements">
  <Reference>C:\Windows\Microsoft.NET\Framework64\v4.0.30319\System.Numerics.dll</Reference>
</Query>

// создадим лямбду, чтобы вычислять факторал
Func<uint, System.Numerics.BigInteger> factorial = null;
factorial = n => (n == 0) ? 1 : n * factorial(n - 1);

// создадим лямбду, чтобы печатать факторал
Action<uint> print = n => Console.WriteLine(factorial(n));

// запустим метод асинхроно, игнорируя дополнительные параметры
print.BeginInvoke(8000, null, null);

// эмулируем работу (результат увидим где-то на третьей итерации)
for (int i = 1; i < 10; i++)
{
	Console.Write("Do some work...");
	Thread.Sleep(1000);
}
