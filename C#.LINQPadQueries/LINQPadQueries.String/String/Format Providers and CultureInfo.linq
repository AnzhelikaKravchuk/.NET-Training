<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// Requesting a specific culture (english language in Great Britain):
CultureInfo uk = CultureInfo.GetCultureInfo ("en-GB");
uk.Dump();
Console.WriteLine (3.ToString ("C", uk));      // £3.00

// Invariant culture:
DateTime dt = new DateTime (2000, 1, 2);
CultureInfo iv = CultureInfo.InvariantCulture;
iv.Dump();
Console.WriteLine (dt.ToString (iv));            // 01/02/2000 00:00:00
Console.WriteLine (dt.ToString ("d", iv));       // 01/02/2000
Console.WriteLine (dt.ToString ());