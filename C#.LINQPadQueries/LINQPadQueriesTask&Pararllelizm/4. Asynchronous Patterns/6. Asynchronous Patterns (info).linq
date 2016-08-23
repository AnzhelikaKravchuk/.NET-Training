<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

//Платформа .NET Framework предоставляет три шаблона для выполнения асинхронных
//операций(http://msdn.microsoft.com/ru-ru/library/jj152938(v=vs.110).aspx):
//
////1. Асинхронный шаблон модели программирования (APM Asynchronous Programming Model)
//(также называемой шаблоном IAsyncResult), где асинхронные операции требуют 
//методов Begin* и End* (например, BeginWrite и EndWrite для асинхронных операций 
//записи). (Пример System.IO.Stream mscorlib.dll). (Асинхронные делегаты).`
// Не рекомендуется применять этот подход к вновь разрабатываемым решениям. (Obsolete Pattern)
//
//2. Асинхронная модель на основе событий (EAP - Event-based Asynchronous Pattern),
//которая требует наличие метода, имеющего суффикс Async, а также требует одно
//или несколько событий,типов делегата обработчика событий и типов, производных 
//от EventArg. Асинхронная модель на основе событий была введена в платформе
//.NET Framework версии 2.0. (Пример System.Net.WebClient - System.dll)
//Универсальное решение класс BackgroundWorker сценарии с пользовательским инерфейсом
//Не рекомендуется применять этот подход к вновь разрабатываемым решениям. (Obsolete Pattern)
//
//3. Асинхронная модель на основе задач (TAP - Task-based Asynchronous Pattern), 
//которая использует один метод для представления инициализации и завершения
//асинхронной операции. 
//TAP впервые появился в платформе .NET Framework 4 и представляет собой 
//рекомендуемый подход к асинхронному программированию в платформе .NET Framework. 
//