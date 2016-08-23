<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

//список статических членов класса System.Array

int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

object searchTerm = 3;
//Array.BinarySearch - осуществляет поиск заданного значения в одномерном отсортированном массиве 
//с использованием алгоритма бинарного поиска.
int result = Array.BinarySearch(numbers,searchTerm);
result.Dump("BinarySearch");

//Array.Clear - Устанавливает значения элементов массива или заданного диапазона элементов 
//в нуль (false или NULL, в зависимости от типа элемента)
Array.Clear(numbers, 2, 2);
numbers.Dump("Clear");

//Array.Copy - Копирует диапазон одного массива в другой. Осуществляет преобразование типов
//и боксинг при необходимости. Подобно функции memmove из CRT Copy корректно 
//обрабатывает ситуацию с перекрытием областей памяти и может использоваться
//для копирования элементов в рамках одного массива. Copy – это самый эффективный 
//способ копирования данных
double[] numbersCopy = new double[5];
Array.Copy(numbers, 0, numbersCopy, 0, 5);
numbersCopy.Dump("Copy");
Array.Copy(numbers,4,numbers,2,2);
numbers.Dump("Copy");

//Array.CreateInstance - Позволяет динамически создать новую копию массива (объекта типа Array)
//хотя и медленнее использования оператора new, но незначительно
int[] arrInst = (int[])Array.CreateInstance(typeof(Int32),5);
arrInst.Dump("CreateInstance");

//Array.IndexOf - Возвращает индекс первого вхождения значения в одномерном массиве 
//или диапазоне значений. Поиск производится простым перебором
int indexFirst = Array.IndexOf(numbers,5);
indexFirst.Dump("IndexOf");

//Array.LastIndexOf - Возвращает индекс последнего вхождения значения в одномерном массиве
//или диапазоне значений. Поиск производится перебором
int indexLast = Array.LastIndexOf(numbers,5);
indexLast.Dump("LastIndexOf");

//Array.Reverse - Меняет порядок следования элементов массива или диапазона на обратный
Array.Reverse(numbers);
numbers.Dump("Reverse");

//Array.Sort - Сортирует элементы в одномерном массиве (с помощью алгоритма QuickSort)
Array.Sort(numbers);
numbers.Dump("Sort");