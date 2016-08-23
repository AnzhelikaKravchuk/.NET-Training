<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
</Query>

StringBuilder hello = new StringBuilder("Добро пожаловать в библиотеку MSDN на русском языке",130);
 hello.Dump();
 hello.AppendFormat("— ценный источник информации для разработчиков, использующих средства, продукты, технологии и службы корпорации Майкрософт®");
 hello.Dump(); 
 
// StringBuilder hello = new StringBuilder("Добро пожаловать в библиотеку MSDN на русском языке",30);
// hello.Dump();
// hello.AppendFormat("— ценный источник информации для разработчиков, использующих средства, продукты, технологии и службы корпорации Майкрософт®");
// hello.Dump();