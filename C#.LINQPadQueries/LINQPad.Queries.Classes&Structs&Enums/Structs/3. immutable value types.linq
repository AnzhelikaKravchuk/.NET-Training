<Query Kind="Program" />

void Main()
{
	List<Mutable> lm = new List<Mutable> { new Mutable(x: 5, y: 5) };
	lm.Dump("List<Mutable> Y++");
	//lm[0].Y++; // Ошибка компиляции
	lm[0].IncrementX(); // ведет к изменению временной переменной
	lm.Dump("List<Mutable> IncrementX");
	Mutable[] am = new Mutable[] { new Mutable(x: 5, y: 5) };
	am.Dump();
	//Console.WriteLine("Исходные значения X: {0}, Y: {1}", am[0].X, am[0].Y);
	am[0].Y++;
	am.Dump("Mutable[] Y++");
	//оптимизация в виде специальной инструкции IL-кода (ldelema)
	//которая позволяет получить не просто копию элемента массива,
	//а ссылку на него.
	//Благодаря этой возможности, предыдущий фрагмент не только 
	//полностью корректен (включая строку am[0].Y++;)
	//но и позволяет изменить непосредственно элементы массива,
	//а не их копии
	am[0].IncrementX();
	am.Dump("Mutable[] IncrementX");
	//Console.WriteLine("Новые значения X: {0}, Y: {1}", am[0].X, am[0].Y);
}


struct Mutable
{
	public Mutable(int x, int y)
		: this()
	{
		X = x;
		Y = y;
	}
	public void IncrementX() { X++; }
	public int X { get; private set; }
	public int Y { get; set; }
}
//http://sergeyteplyakov.blogspot.com.by/2011/07/blog-post.html