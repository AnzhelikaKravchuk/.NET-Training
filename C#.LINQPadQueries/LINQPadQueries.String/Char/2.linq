<Query Kind="Statements" />

// char literals:
char c = 'A';
char newLine = '\n';

// System.Char defines a range of static methods for working with characters:
char.ToUpper ('c').Dump();				// C
char.IsWhiteSpace ('\t').Dump();;		// True
char.IsLetter ('x').Dump();			// True
char.GetUnicodeCategory ('x').Dump();	// LowercaseLetter