<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	
}

static T Max <T> (T a, T b) where T : IComparable<T>
{
    return a.CompareTo (b) > 0 ? a : b;
}

static T Max <T> (T a, T b)
{
    return a > b ? a : b;             //C# Compile error
}

static T Max <T> (T a, T b)
{
   	return a > b ? a : b;             //C++ Compile error for concrete T
}

//Это иллюстрирует то, что обобщения в C# не похожи на шаблоны в C++. 
//Вы можете думать о шаблонах, как о продвинутом механизме поиска и замены. 
//Когда вы говорите Max<string> в шаблоне, компилятор ищет все применения «T»,
//заменяет их на «string», а потом компилирует получившийся исходный код.
//Разрешение перегрузок работает с подставленными типами-аргументами, 
//и сгенерированный код отражает результаты этого разрешения
