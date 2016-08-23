<Query Kind="Statements" />

//Кроме всего прочего, необходимо заметить, что для создания массива необходимо
//жестко задать его размер. В дальнейшем размер массива изменен быть не может. 

//two-dimension array [2005..2009][1..4].
int[] lowerBounds = { 2005, 1 };
int[] lengths = { 5, 4 };
      
var arr = Array.CreateInstance(typeof(Decimal), lengths, lowerBounds);
arr.SetValue(12M,2005,1);
arr.GetValue(2009,4).Dump();
    
//можно создавать и обычные одномерные массивы с нулевой нижней границей
int[] a = (int[])Array.CreateInstance(typeof(int), 
										new int[] { 2 }, // Список размеров измерений.
   										new int[] { 0 }  // Нижняя граница для каждого измерения.
  									);
a.GetType().Dump();

(Array.CreateInstance(typeof(int), 
								new int[] { 2 }, // Список размеров измерений.
   								new int[] { 1 }  // Нижняя граница для каждого измерения.
  					)).GetType().Dump();