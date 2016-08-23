<Query Kind="Statements" />

//Despite ordinal’s limitations, string’s == operator always performs 
//ordinal casesensitive comparison. The same goes for the instance 
//version of string.Equals when called without arguments; this defines 
//the “default” equality comparison behavior for the string type.

string s1 = Console.ReadLine();
string s2 = Console.ReadLine();

(s1 == s2).Dump("s1 == s2");

(s1.Equals(s2)).Dump("s1.Equals(s2)");

string.Equals(s1,s2).Dump("Equals(s1,s2)");

ReferenceEquals(s1,s2).Dump("ReferenceEquals(s1,s2)");

s1 = string.Intern(s1);
s2 = string.Intern(s2);
ReferenceEquals(s1,s2).Dump("Intern ReferenceEquals(s1,s2)");

//http://msdn.microsoft.com/ru-ru/library/system.string.intern(v=vs.110).aspx

string a = "test";
string b = "test";
(a == b).Dump("a == b"); // True

ReferenceEquals(a,b).Dump("ReferenceEquals(a, b)");//интернирование строк

//public bool Equals(string value, StringComparison comparisonType);
//public static bool Equals (string a, string b, StringComparison comparisonType);

string.Equals ("foo", "FOO", StringComparison.OrdinalIgnoreCase).Dump("foo = FOO?");   // True