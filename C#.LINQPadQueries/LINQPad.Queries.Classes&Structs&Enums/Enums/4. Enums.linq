<Query Kind="Program" />

// An enum is a special value type that lets you specify a group of named numeric constants:

public enum BorderSide 
{ 
	Left,
	Right,
	Top,
	Bottom
}

static void Main()
{
	BorderSide topSide = BorderSide.Top;
	bool isTop = (topSide == BorderSide.Top);	
	isTop.Dump();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

// You may specify an alternative integral type:
public enum BorderSideByte : byte 
{ 
	Left,
	Right,
	Top, 
	Bottom 
}

// You may also specify an explicit underlying value for each enum member:
public enum BorderSideExplicit : byte 
{ 
	Left =1, 
	Right = 2, 
	Top = 10, 
	Bottom = 11 
}

public enum BorderSidePartiallyExplicit : byte 
{ 
	Left = 1, 
	Right, 
	Top = 10,
	Bottom 
}