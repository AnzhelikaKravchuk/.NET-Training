<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	int i = 1;
	int j = 2;
	int result = Sum(++i, i+j);
	result.Dump();
	result = Sum(i++, i+j);
	result.Dump();
}

int Sum(int first, int second)
{
    return first + second;
}

#region IL
//IL_0001:  ldc.i4.1    загружает в стек целое значение 1
//IL_0002:  stloc.0     извлекает из стека верхнее значение и помещает его в локальную переменную i;
//Извлекает из стека значение и сохраняет его в локальной переменной с индексом index (0)
//IL_0003:  ldc.i4.2    загружает в стек целое значение 2; ldc.i4 num - Помещает значение num в стек
//IL_0004:  stloc.1     извлекает из стека верхнее значение и помещает его в локальную переменную j
//IL_0005:  ldarg.0     Загружает аргумент 0 в стек.
//IL_0006:  ldloc.0     загружает в стек локальную переменную i
//IL_0007:  ldc.i4.1    Помещает значение 1 в стек
//IL_0008:  add         Складывает
//IL_0009:  dup  		Копирует текущее верхнее значение в стеке вычислений и помещает копию в стек вычислений
//IL_000A:  stloc.0     извлекает из стека верхнее значение и помещает его в локальную переменную i
//IL_000B:  ldloc.0     загружает в стек локальную переменную i
//IL_000C:  ldloc.1     загружает в стек локальную переменную j; Загружает в стек локальную переменную с индексом index
//IL_000D:  add         Складывает два числовых значения и возвращает новое числовое значение
//IL_000E:  call        UserQuery.Sum
//IL_0013:  stloc.2     извлекает из стека верхнее значение и помещает его в локальную переменную result

//
//Sum:
//IL_0000:  nop         Операция nop не выполняет никаких действий
//IL_0001:  ldarg.1     Загружает аргумент 1 в стек.
//IL_0002:  ldarg.2     Загружает аргумент 2 в стек.
//IL_0003:  add         
//IL_0004:  stloc.0     // CS$1$0000 извлекает из стека верхнее значение и помещает его в локальную переменную
//IL_0005:  br.s        Выполняет переход к конечной инструкции с указанным смещением IL_0007 
//IL_0007:  ldloc.0     // CS$1$0000
//IL_0008:  ret      	Выполняет возврат из метода

//https://msdn.microsoft.com/ru-ru/library/system.reflection.emit.opcodes.ret(v=vs.110).aspx
#endregion