<Query Kind="Statements">
  <Namespace>System.Globalization</Namespace>
</Query>

// The simplest formatting mechanism is the ToString method.
//It gives meaningful output on all simple value types
//(bool, DateTime, DateTimeOffset, TimeSpan, Guid,
//and all the numeric types). 
//For the reverse operation, each of these types defines a static Parse method. 
string s = true.ToString();
s.Dump();
TimeSpan time = new TimeSpan(1,10,0);
time.ToString().Dump();
Guid guid = new Guid();
guid.ToString().Dump();

// Parse does the reverse:
bool b = bool.Parse (s);
b.Dump();

// TryParse avoids a FormatException in case of error:
int i;
int.TryParse ("qwerty", out i).Dump ("Successful");
int.TryParse ("123", out i).Dump ("Successful");

// Culture trap:
Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo ("de-DE");  // Germany
double.Parse ("1.234").Dump ("Parsing 1.234 (de-DE)");   // 1234 

// Specifying invariant culture fixes this:
double.Parse ("1.234", CultureInfo.InvariantCulture).Dump ("Parsing 1.234 Invariantly");

(1.234).ToString ().Dump ("1.234.ToString()");
(1.234).ToString (CultureInfo.InvariantCulture).Dump ("1.234.ToString Invariant");