<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

class Employee
{
	private int salary;
	private string name;
	private string department;
	
	public string GetName() { return name; }
	public void SetName(string value){ name = value; }
	
	public string GetDepartment() { return department; }
	public void SetDepartment(string value){ department = value; }
	
	public int GetSalary() { return salary; }
	public void SetSalary(int value) { salary = (value >= 0 && value <= 1000000) ? value : 0; }
	
	public Employee(string name)
	{
		this.name = name;
		this.salary = 10000;
		this.department = "Customer Service";
	}

	public override string ToString()
	{
		return String.Format("{0} earns ${1} and is in the {2} department.", name, salary.ToString(), department.ToLower());
	}
}

void Main()
{
	Employee employee = new Employee("Joe");
	employee.SetSalary(12000000);
	employee.GetName().Dump("name:");
	
	employee.Dump("emoloyee: ");
}