<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	Rectangle r = new Rectangle();
	Point p = new Point();
	p.Dump();
	r.Dump();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe",Assembly.GetExecutingAssembly().Location);
}

public class Rectangle
{
	public string s;
	public int x;
	public Point topLeft, bottonRigth;
	
	public Rectangle()
	{
		//topLeft = new Point();
	}
}

public struct Point
{
	public int x, y;
	public string s;
	
	public Point(int x, int y)
	{
		this.x = x;
		this.y = y;
		this.s = string.Empty;
	}
}