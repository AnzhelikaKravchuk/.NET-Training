<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// The format string provides instructions; 
//the format provider determines how the instructions are translated:

//Format providers allow extensive control over formatting and parsing, 
//and are supported for numeric types and date/times. 
//Format providers are also used by user interface controls for formatting and parsing.


//The gateway to using a format provider is IFormattable. 
//All numeric types—and DateTime(Offset)—implement this interface:

//public interface IFormattable
//{
//      string ToString (string format, IFormatProvider formatProvider);
//}


//The .NET Framework defines three format providers (all of which implement IFormatProvider):
//     	NumberFormatInfo
//     	DateTimeFormatInfo
//     	CultureInfo

//public interface IFormatProvider
//{
//		object GetFormat(Type formatType)
//}

NumberFormatInfo f = new NumberFormatInfo();
f.Dump();
f.CurrencySymbol = "**";
Console.WriteLine (3.ToString ("C", f));          // $$ 3.00

// The default format provider is CultureInfo.CurrentCulture:
Console.WriteLine (10.3.ToString ("C", null));

// For convenience, most types overload ToString such that you can omit a null provider:
Console.WriteLine (10.3.ToString ("C"));
Console.WriteLine (10.3.ToString ("F4"));		// (Fix to 4 D.P.)