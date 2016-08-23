<Query Kind="Statements" />

//public static object ChangeType (object value, Type conversionType);

Type targetType = typeof (int);
object source = "42";
object result = Convert.ChangeType (source, targetType);
result.Dump();             // 42
result.GetType().Dump();