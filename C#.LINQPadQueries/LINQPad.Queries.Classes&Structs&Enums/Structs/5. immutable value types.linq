<Query Kind="Program" />

void Main()
{
	using (var ds = new Disposable())
	{
		// Используем объект d
	}

	var d = new Disposable();
	using (d)
	{
		// Используем объект d
	}

	// Выведет: Disposed: true? или Disposed: false?
	Console.WriteLine("Disposed: {0}", d.Disposed);
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

struct Disposable : IDisposable
{
	public bool Disposed { get; private set; }
	public void Dispose() { Disposed = true; }
}

//var d = new Disposable();
//
//{
//	// Дополнительная область видимости для того, чтобы нельзя было 
//	// использовать переменную, объявленную в блоке using за его пределами
//	var tmp = d; 
//  try
//	{
//		// Тело блока using
//	}
//	finally
//	{
//		// Проверка на null для обычных (не-nullable) структур не нужна
//		((IDisposable)tmp).Dispose();
//	}
//}