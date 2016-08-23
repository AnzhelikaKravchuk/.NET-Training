<Query Kind="Statements" />

//String’s CompareTo instance method performs culture-sensitive,
//case-sensitive order comparison. Unlike the == operator, 
//CompareTo does not use ordinal comparison: for ordering, 
//a culture-sensitive algorithm is much more useful.
//
//    	public int CompareTo (string strB);
//
//		public static int Compare (string strA, string strB,
//                                StringComparison comparisonType);
//    	public static int Compare (string strA, string strB, bool ignoreCase,
//                                CultureInfo culture);
//    	public static int Compare (string strA, string strB, bool ignoreCase);
//    	public static int CompareOrdinal (string strA, string strB)

// The order comparison methods return a positive number, a negative number, or zero, depending
// on whether the first value comes after, before, or alongside the second value:
"Boston".CompareTo ("Austin").Dump();    // 1
"Boston".CompareTo ("Boston").Dump();    // 0
"Boston".CompareTo ("Chicago").Dump();   // -1
"foo".CompareTo ("FOO").Dump();          // -1

// The following performs a case-insensitive comparison using the current culture:
string.Compare ("foo", "FOO", true).Dump();   // 0

// By supplying a CultureInfo object, you can plug in any alphabet:
var german = System.Globalization.CultureInfo.GetCultureInfo ("de-DE");
int i = string.Compare ("Müller", "Muller", false, german);
i.Dump();	// 1