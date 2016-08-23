<Query Kind="Statements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

Expression<Func<string,bool>> expr = text => text.Length < 5;

var parameters = expr.Parameters;

foreach (var param in parameters)
{
    Console.WriteLine("\tParameter Name: {0}", param.Name);
    Console.WriteLine("\tParameter Type: {0}", param.Type.Name );
}

var bodyExpr = expr.Body as BinaryExpression;
Console.WriteLine("Expression Type: {0}", expr.NodeType);
Console.WriteLine("Left side of body expression: {0}", bodyExpr.Left);
Console.WriteLine("Binary Expression Type: {0}", bodyExpr.NodeType);
Console.WriteLine("Right side of body expression: {0}", bodyExpr.Right);
Console.WriteLine("Return Type: {0}", expr.ReturnType);