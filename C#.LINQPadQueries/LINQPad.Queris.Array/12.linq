<Query Kind="Statements" />

//[Serializable]
//public abstract class Array : ICloneable, IList, ICollection, 
//IEnumerable, IStructuralComparable, IStructuralEquatable

int[] numbersSource = { 1, 2, 3, 4, 5 };
//numbersSource.Dump("array numbers");

object numbersClone = numbersSource.Clone();
numbersClone.Dump("clone of array numbers (Clone)");
Console.WriteLine(numbersSource == numbersClone);
Console.WriteLine(numbersSource.Equals(numbersClone));
Console.WriteLine(Array.Equals(numbersSource,numbersClone));
Console.WriteLine(Array.ReferenceEquals(numbersSource,numbersClone));

int[] numbersCopy = new int[numbersSource.Length];
numbersSource.CopyTo(numbersCopy, 0);
numbersCopy.Dump("copy of array numbers (CopyTo)");
Console.WriteLine(numbersSource == numbersCopy);
Console.WriteLine(numbersSource.Equals(numbersCopy));
Console.WriteLine(Array.Equals(numbersSource,numbersCopy));
Console.WriteLine(Array.ReferenceEquals(numbersSource,numbersCopy));

int[] numbersAgain = numbersSource;
//numbersAgain.Dump("copy of array numbers (copy ref)");
//Console.WriteLine(numbersSource == numbersAgain);
Console.WriteLine(numbersSource == numbersAgain);
Console.WriteLine(numbersSource.Equals(numbersAgain));
Console.WriteLine(Array.Equals(numbersSource,numbersAgain));
Console.WriteLine(Array.ReferenceEquals(numbersSource,numbersAgain));
//(numbersSource == numbersClone).Dump("numbersSource == numbersClone");
//(numbersSource == numbersCopy).Dump("numbersSource == numbersCopy"); 
//(numbersSource == numbersAgain).Dump("numbersSource == numbersAgain");

//Структурное равенство означает, что два объекта равны, 
//поскольку они имеют равные значения. Он отличается от 
//равенства ссылок, при котором две объектные ссылки равны,
//если они ссылаются на один и тот же физический объект. 
//Интерфейс IStructuralEquatable позволяет реализовать 
//пользовательские сравнения для проверки структурного 
//равенства объектов коллекции. Это означает, что можно 
//создать свое собственное определение структурного равенства 
//и указать, что это определение должно использоваться для 
//типа коллекции, который принимает интерфейс IStructuralEquatable. 
//В интерфейсе два члена: Equals, который проверяет равенство 
//с помощью специальной реализации IEqualityComparer, и GetHashCode,
//возвращающий одинаковые хэш-коды для объектов, которые равны.
"IStructuralEquatable".Dump();
IStructuralEquatable numbers = numbersSource;

numbers.Equals(numbersClone, StructuralComparisons.StructuralEqualityComparer).Dump("numbersSource == numbersClone");
numbers.Equals(numbersCopy, StructuralComparisons.StructuralEqualityComparer).Dump("numbersSource == numbersCopy");
numbers.Equals(numbersAgain, StructuralComparisons.StructuralEqualityComparer).Dump("numbersSource == numbersCopy");