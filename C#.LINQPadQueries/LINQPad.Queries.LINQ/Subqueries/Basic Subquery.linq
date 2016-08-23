<Query Kind="Statements">
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

string[] musos = { "Rick Wright", "Roger Waters", "David Gilmour"};

musos.OrderBy (m => m.Split().Last()).Dump ("Sorted by last name");