<Query Kind="Statements" />

int i = 3;
int j = i++;
int k = ++i;
i.Dump();
j.Dump();
k.Dump();

//IL_0000: nop
//IL_0001:  ldc.i4.3
//IL_0002: stloc.0     // i
//IL_0003: ldloc.0     // i
//IL_0004: stloc.3
//IL_0005: ldloc.3
//IL_0006: ldc.i4.1
//IL_0007: add
//IL_0008:  stloc.0     // i
//IL_0009: ldloc.3
//IL_000A: stloc.1     // j
//IL_000B: ldloc.0     // i
//IL_000C: ldc.i4.1
//IL_000D: add
//IL_000E:  stloc.3
//IL_000F: ldloc.3
//IL_0010: stloc.0     // i
//IL_0011: ldloc.3
//IL_0012: stloc.2     // k
//IL_0013: ldloc.0     // i
//IL_0014: call LINQPad.Extensions.Dump
//IL_0019:  pop
//IL_001A:  ldloc.1     // j
//IL_001B: call LINQPad.Extensions.Dump
//IL_0020:  pop
//IL_0021:  ldloc.2     // k
//IL_0022: call LINQPad.Extensions.Dump
//IL_0027:  pop
//IL_0028:  ret  