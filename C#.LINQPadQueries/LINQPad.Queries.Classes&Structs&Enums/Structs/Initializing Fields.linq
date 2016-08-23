<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	var o = new Basis();
	o.Dump();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

class Basis 
{
	private Vector _direction1;
	private Vector _direction2; 
}

class Vector 
{
	private Point _start;
	private Point _end; 
}

struct Point 
{
	private int _x;
	private int _y; 
}