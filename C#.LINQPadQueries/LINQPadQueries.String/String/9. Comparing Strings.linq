<Query Kind="Statements" />

//In comparing two values, the .NET Framework differentiates 
//the concepts of equality comparison and order comparison. 
//
//Equality comparison tests whether two instances are semantically the same;
//order comparison tests which of two (if any) instances comes first 
//when arranging them in ascending or descending sequence.

//For string equality comparison, you can use the == operator or
//one of string’s Equals methods

//For string order comparison, you can use either the CompareTo 
//instance method or the static Compare and CompareOrdinal methods

//There are two basic algorithms for string comparison: ordinal and culture-sensitive. 
//Ordinal comparisons interpret characters simply as numbers 
//(according to their numeric Unicode value); 
//culture-sensitive comparisons interpret characters with reference 
//to a particular alphabet. 
//There are two special cultures: the “current culture,” which 
//is based on settings picked up from the computer’s control panel,
//and the “invariant culture,” which is the same on every computer
//(and closely matches American culture).

//For equality comparison, both ordinal and culture-specific algorithms are useful.
//For ordering, however, culture-specific comparison is nearly always preferable:
//to order strings alphabetically, you need an alphabet.

//The invariant culture puts them in the following order:
//     "Atom", "atom", "Zamia"
//Ordinal arranges them instead as follows:
//     "Atom", "Zamia", "atom"