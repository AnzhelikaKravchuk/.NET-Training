<Query Kind="Statements" />

//Serializable]
//public abstract class Array : ICloneable, IList, ICollection, IEnumerable, IStructuralComparable, IStructuralEquatable
// => Любой экземпляр массива обладает свойствами и методами класса System.Array, 
//а также позволяет пользоваться статическими методами этого класса для манипуляций
//с его содержимым

int[] array = new int[2];
array.Length.Dump("Length");//IL - !!!

//Наследников Array могут создавать только компиляторы и система!
//простые одномерные массивы с нижней границей, равной нулю, 
//поддерживаются непосредственно средой исполнения, и для манипуляции
//с ними в MSIL имеется специализированный набор инструкций IL-code

//Kомпиляторы эмулируют для программиста идеально похожую на настоящую
//«объектноориентированность», но в то же время генерируют максимально эффективный код
//В этом процессе участвует и runtime
array.IsReadOnly.Dump("IsReadOnly");

//специальные IL-команды (такие как newarr, ldelem, ldelema, ldlen и stelem) для работы 
//с одномерными массивам с нулевой нижней границей, которые позволяют JIT-компилятору 
//генерировать оптимизированный машинный код
Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);