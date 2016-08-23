<Query Kind="Statements" />

var bits = new BitArray(2);
bits.Dump();
bits[1] = true;
bits.Xor (bits);               // Bitwise exclusive-OR bits with itself
Console.WriteLine (bits[1]);   // False