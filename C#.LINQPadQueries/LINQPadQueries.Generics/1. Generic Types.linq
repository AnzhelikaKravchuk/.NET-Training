<Query Kind="Program" />

// Обобщенный тип определяет параметры типа -  параметры-заполнители,
// предназначенные для заполнения потребителем обощенного типа,
// который представляет аргументы типа:

public class Stack<T>//открытый тип
{
  int position;
  T[] data = new T[100];
  public void Push (T obj)   { data[position++] = obj;  }
  public T Pop()             { return data[--position]; }
}

static void Main()
{
	//заполняет параметр типа агрументом int, неявно на лету создавая тип
	//(синтез во время выполнения) 
	Stack<int> stack = new Stack<int>();//закрытый тип
	stack.Push(5);
	stack.Push(10);
	int x = stack.Pop();        // x is 10
	int y = stack.Pop();        // y is 5
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}