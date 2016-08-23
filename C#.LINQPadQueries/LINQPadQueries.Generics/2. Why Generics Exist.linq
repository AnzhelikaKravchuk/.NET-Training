<Query Kind="Program" />

// Обобщения предназначены для записи кода, который может
//многократно использоваться между различными типами

public class ObjectStack
{
	int position;
	object[] data = new object[10];
	public void Push (object obj) { data[position++] = obj;  }
	public object Pop()           { return data[--position]; }
}

static void Main()
{
	// Now suppose we want a stack that stores just integers:
	ObjectStack stack = new ObjectStack();
	
	// It's easy to make mistakes:
	stack.Push ("s");          // Wrong type, but no error!
	int i = (int)stack.Pop();  // Downcast - runtime error!
}

//Главные преимущества обобщении.
// - Защита исходного кода. 
// - Безопасность типов. 
// - Более простой и понятный код. 
// - Повышение производительности.