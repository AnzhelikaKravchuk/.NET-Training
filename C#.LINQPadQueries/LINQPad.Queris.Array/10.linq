<Query Kind="Statements" />

//список экземплярных методов System.Array

int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
//Clone - Создает копию (клон) массива. При этом происходит так называемое неглубокое 
//клонирование. Копируется только содержание самого массива. Если массив 
//содержит элементы ссылочного типа, или структуры, содержащие ссылки, эти 
//ссылки будут указывать на те же объекты, что и в основном массиве
object numbersClone = numbers.Clone();
numbersClone.Dump("Clone");

//CopyTo - Копирует все элементы текущего одномерного массива в указанный одномерный массив
int[] newNumbers = new int[numbers.Length + 1];
//Сору() требует наличия существующего массива той же 
//размерности с достаточным количеством элементов!
numbers.CopyTo(newNumbers, 1);
newNumbers.Dump("CopyTo");

numbers.GetLength(0).Dump("GetLength");
//GetLongLength, GetLowerBound, GetUpperBound 

numbers.GetValue(4).Dump("GetValue");
numbers.SetValue(44,4);
numbers.GetValue(4).Dump("GetValue");

//Все перечисленные методы (за исключением GetValue и SetValue) работают очень быстро. 
//GetValue и SetValue работают крайне медленно