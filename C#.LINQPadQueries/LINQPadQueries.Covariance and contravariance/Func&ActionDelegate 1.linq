<Query Kind="Program" />

delegate Func<T> FuncFunc<out T>();
delegate void ActionAction<out T>(Action<T> action);
delegate void ActionFunc<in T>(Func<T> function);
delegate Action<T> FuncAction<in T>();

//В качестве эмпирического правила: можно рассматривать вложенную
//контравариантность как инверсию предыдущей вариантности,
//а ковариантность - нет,поэтому, несмотря на то, что делегат
//Action<Action<T>> ковариантен в Т, делегат Action<Action<Action<T>>> 
//контравариантен.
//Для сравнения с вариантностью Func<T>, где можно записывать 
//Func<Func<Func<...Func<T>...>>> с произвольной глубиной 
//вложения и по-прежнему иметь ковариантность.

void Main()
{

}
