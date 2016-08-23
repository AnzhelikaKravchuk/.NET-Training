<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Employee
{
	private int salary;
	private string name;
	
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
	
	public string Name { get { return name;} set { name = value;} }
	//Automatically Implemented Properties, AIP
	public string Department { get; set; }
	
	public Employee(string name)
	{
		this.Name = name;
		this.Salary = 10000;
		this.Department = "Customer Service";
	}

	public override string ToString()
	{
		return String.Format("{0} earns ${1} and is in the {2} department.", Name, Salary.ToString(), Department.ToLower());
	}
}

void Main()
{
	Employee employee = new Employee("Joe") { Salary = 22000 };
	employee.Dump();
	Process.Start (@"C:\Program Files (x86)\Red Gate\.NET Reflector\Desktop 8.0\Reflector.exe", 
		Assembly.GetExecutingAssembly().Location);
}