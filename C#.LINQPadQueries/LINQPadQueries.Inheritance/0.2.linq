<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

void Main()
{
	
}
class Employee
{
    protected string empName;
    public Employee(string name) 
    {
        this.empName = name;
    }
}
 
class Manager : Employee
{
    protected string empGrade;
    public Manager(string name, string grade) : base(name)
    {
        this.empGrade = grade;
    }
}