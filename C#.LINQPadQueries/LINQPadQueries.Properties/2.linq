<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Employee
{
	private int salary;
	private string name;
	private string department;
	
	public int Salary
	{
		get
		{
			return salary;
		}
		set
		{
			salary = value >= 0 ? value : 0;
		}
	}
	
	public string Name { get { return name; } private set { name = value; } }
	public string Department { get { return department; } set {department = value; } }
	
	public Employee(string name)
	{
		this.Name = name;
		this.Department = string.Empty;
	}

	public override string ToString()
	{
		return String.Format("{0} earns ${1} and is in the {2} department.", Name, Salary.ToString(), Department.ToLower());
	}
}

void Main()
{
	Employee employee = new Employee("Joe");
	employee.Department = "Customer Service";
	employee.Salary = 10500;
	employee.Department.Dump();
}