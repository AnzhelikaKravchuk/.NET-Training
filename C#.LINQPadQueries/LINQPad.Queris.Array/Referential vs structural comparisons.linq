<Query Kind="Statements" />

object[] obj1 = { "string", 123, true };
object[] obj2 = { "string", 123, true };

Console.WriteLine (obj1 == obj2);                          // False
Console.WriteLine (obj1.Equals (obj2));                    // False

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
IStructuralEquatable obj = obj1;

Console.WriteLine (obj.Equals (obj2, StructuralComparisons.StructuralEqualityComparer));   // True