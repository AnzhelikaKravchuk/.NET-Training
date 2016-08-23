<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

//var func = x => x + 1;//CTE

//поскольку любое лямбда-выражение может быть присвоено 
//переменным двух типов: делегату или выражению
Func<int, int> func = x => x + 1;
//аналогично Func<int, int> func = new Func<int, int>(x => x + 1);
func.GetType().ToString().Dump();

Expression<Func<int, int>> expression = x => x + 1;
//неявное преобразование лямбда-выражения в Expression<TDelegate>
//заставляет компилятор выдать код, который строит дерево выражений!
expression.GetType().ToString().Dump();

func(2).Dump("func");
//expression(2).Dump("expression");
//получим функтор, аналогичный тому, что мы получим в первом случае, 
//однако сгенерирован он будет во время выполнения с помощью 
//Reflection.Emit, а не во время компиляции компилятором C#
var t = expression.Compile();
t(2).Dump("expression");