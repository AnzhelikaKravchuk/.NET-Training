<Query Kind="Program" />

public class Point
{
	public double x, y;
	public Point()	{ }
	public Point (double x, double y) { this.x = x; this.y = y; }
}

public class Point2D
{
	public double x, y;
	public Point2D(double x, double y) { this.x = x; this.y = y; }
}

static void Main()
{
	Point p1 = new Point ();       // p1.x and p1.y will be 0
	p1.Dump();
	
	Point p2 = new Point (1, 1);   // p1.x and p1.y will be 1
	p2.Dump();
}