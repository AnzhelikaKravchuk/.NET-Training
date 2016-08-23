<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

{
	Expression<Func<int, int>> expression = x => x + 1;
	(expression.Compile())(11).Dump();
	expression.Dump("Expression tree");
}
//компилятор преобразует указанное лямбда-выражение в дерево 
//выражения (Expression Tree), 
//где каждый узел дерева представляет собой выражение,
//такое как вызов метода, 
//унарный или бинарный оператор и т.д.

{
	var x = Expression.Parameter(typeof(int), "x");
	var constExpr = Expression.Constant(1);
	var binExpr = Expression.Add(x,constExpr);
	var expression = Expression.Lambda<Func<int, int>>(binExpr,x);
	(expression.Compile())(11).Dump();
	expression.Dump("Expression tree");
}

//получаем код в виде данных, которые затем можно сериализовать, 
//передать в другой контекст, проанализировать, преобразовать в совершенно
//другой формат (например, в SQL) и уже потом выполнить