<Query Kind="Program" />

class Point{ public double x,y; }

void Main()
{
	Point[] pointsSource = { new Point { x = 1, y = 1}, new Point { x = 2, y = 2} };
	pointsSource.Dump("array numbers");
	
	object pointsClone = pointsSource.Clone();
	pointsClone.Dump("clone of array numbers (Clone)");
	
	Point[] pointsCopy = new Point[pointsSource.Length];
	pointsSource.CopyTo(pointsCopy, 0);(pointsSource==pointsCopy).Dump();
	pointsCopy.Dump("copy of array numbers (CopyTo)");
	
	Point[] pointsAgain = pointsSource;
	pointsAgain.Dump("copy of array numbers (copy ref)");
	
	(pointsSource == pointsClone).Dump("numbersSource == numbersClone");
	(pointsSource==pointsCopy).Dump("numbersSource == pointsCopy");
	(pointsSource == pointsAgain).Dump("numbersSource == numbersAgain");
	
	pointsSource[0].x = 11;
	pointsSource[0].y = 11;
	
	"Change".Dump();
	(pointsSource).Dump("Source");
	(pointsCopy).Dump("Copy");
	(pointsClone).Dump("Clone");
	(pointsAgain).Dump("Again");
	Console.WriteLine(pointsAgain[0].x);
	Console.WriteLine(pointsAgain[0].y);
	
	"IStructuralEquatable".Dump();
	IStructuralEquatable points = pointsSource;
	
	Console.WriteLine(points.Equals(pointsClone, StructuralComparisons.StructuralEqualityComparer));
	Console.WriteLine(points.Equals(pointsCopy, StructuralComparisons.StructuralEqualityComparer));
	Console.WriteLine(points.Equals(pointsAgain, StructuralComparisons.StructuralEqualityComparer));

	
//	points.Equals(pointsClone, StructuralComparisons.StructuralEqualityComparer).Dump("numbersSource == numbersClone");
//	points.Equals(pointsCopy, StructuralComparisons.StructuralEqualityComparer).Dump("numbersSource == numbersCopy");
//	points.Equals(pointsAgain, StructuralComparisons.StructuralEqualityComparer).Dump("numbersSource == numbersCopy");
}