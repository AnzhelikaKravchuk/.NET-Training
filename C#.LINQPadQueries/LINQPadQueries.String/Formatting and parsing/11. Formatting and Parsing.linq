<Query Kind="Statements" />

//Formatting means converting to a string; parsing means converting from a string.
//The need to format or parse arises frequently in programming, in a variety of situations.
//Hence, the .NET Framework provides a variety of mechanisms:
// - ToString and Parse
//		These methods provide default functionality for many types.
// - Format providers
//		These manifest as additional ToString (and Parse) methods that accept
//		a format string and/or a format provider. Format providers are highly flexible 
//		and culture- aware. The .NET Framework includes format providers for the numeric
//		types and DateTime/DateTimeOffset.
// - XmlConvert
//		This is a static class with methods that format and parse while 
//		honoring XML standards. XmlConvert is also useful for general-purpose conversion 
//		when you need culture independence or you want to preempt misparsing. 
//		XmlConvert supports the numeric types, bool, DateTime, DateTimeOffset, TimeSpan, and Guid.
// - Type converters
//		These target designers and XAML parsers.