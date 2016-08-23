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

interface IFactory<out T>
{
   T CreateInstance();
}

interface IPrettyPrinter<in T>
{
   void Print(T document);
}

interface IStorage<T>
{
   byte[] Serialize(T value);
   T Deserialize(byte[] data);
}
//Любое преобразование, использующее вариантность или ковариантность -
//это ссылочное преобразование, т.е. после преобразования возвращается 
//та же самая ссылка
//Преобразование не создает новый объект; оно просто трактует существующую
//ссылку, как если бы она соответствовала целевому типу. Это точно совпадает
//с приведением между ссылочными типами в иерархии: 
//если привести Stream к MemoryStream (или применить неявное 
//преобразование другим способом), по-прежнему останется только один объект.