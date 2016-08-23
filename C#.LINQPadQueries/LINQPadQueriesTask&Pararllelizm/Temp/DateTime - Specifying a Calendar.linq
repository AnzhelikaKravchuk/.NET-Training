<Query Kind="Statements" />

DateTime d = new DateTime (5767, 1, 1, new System.Globalization.HebrewCalendar());
new System.Globalization.HebrewCalendar().Dump();
Console.WriteLine (d);    // 12/12/2006 12:00:00 AM
d.Dump("data time (Hebrew) = ");
DateTime d1 = new DateTime (2006, 9, 23, new System.Globalization.GregorianCalendar());
new System.Globalization.GregorianCalendar().Dump();
d1.Dump("data time (Gregorian) = ");
(d == d1).Dump("Hebrew data = Gregorian data");