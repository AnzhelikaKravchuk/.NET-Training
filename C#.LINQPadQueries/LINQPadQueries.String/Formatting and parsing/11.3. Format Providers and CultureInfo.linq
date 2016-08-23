<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

//Within the context of format providers, CultureInfo acts 
//as an indirection mechanism for the other two format providers,
//returning a NumberFormatInfo or DateTime FormatInfo object 
//applicable to the culture’s regional settings.

// Requesting a specific culture (english language in Great Britain):
CultureInfo uk = CultureInfo.GetCultureInfo ("en-GB");
uk.Dump();
(3.ToString ("C", uk)).Dump();      // £3.00

// Invariant culture:
DateTime dt = new DateTime (2000, 1, 2);
CultureInfo iv = CultureInfo.InvariantCulture;
iv.Dump();

Console.WriteLine (dt.ToString (iv));            // 01/02/2000 00:00:00
Console.WriteLine (dt.ToString ("d", iv));       // 01/02/2000