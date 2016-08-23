<Query Kind="Statements">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>


{
IEnumerable<char> query = "Not what you might expect";
query = query.Where (c => c != 'a');
query = query.Where (c => c != 'e');
query = query.Where (c => c != 'i');
query = query.Where (c => c != 'o');
query = query.Where (c => c != 'u');
foreach(char c in query) //Nt wht y mght xpct
    Console.Write(c);
}

{
IEnumerable<char> query = "Not what you might expect";
string vowels = "aeiou";
for (int i = 0; i < vowels.Length; i++)
    query = query.Where (c => c != vowels[i]);
foreach(char c in query) //IndexOutOfRangeException
    Console.Write(c);
}