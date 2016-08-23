<Query Kind="Statements" />


{
IEnumerable<char> query = "Not what you might expect";
string vowels = "aeiou";
for (int i = 0; i < vowels.Length; i++)
{
    char vowel = vowels[i];
    query = query.Where (c => c != vowel);
}
foreach(char c in query) //Nt wht y mght xpct
    Console.Write(c);
}
 Console.WriteLine();
{
IEnumerable<char> query = "Not what you might expect";

foreach (char vowel in "aeiou") //C# 5.0 
    query = query.Where (c => c != vowel);

foreach(char c in query)
    Console.Write(c);
}
