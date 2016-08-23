<Query Kind="Statements" />

// String literals:
string s1 = "Hello";
string s2 = "First Line\r\nSecond Line";
string s3 = "С:\\Windows\\System32\\Notepad.exe";
string s4 = @"C:\Windows\System32\Notepad.exe";

//string s = new string("Hi there.");
//System.String s = new System.String("Hi there.");

// To create a repeating sequence of characters you can use string’s constructor:
(new string ('*', 10)).Dump();    // **********

// You can also construct a string from a char array. ToCharArray does the reverse:
char[] ca = "Hello".ToCharArray();
string s = new string (ca);              // s = "Hello"
s.Dump();