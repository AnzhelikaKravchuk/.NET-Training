<Query Kind="Statements">
  <Connection>
    <ID>c1aeac61-b72c-4374-8b36-d07566fdaa1f</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\MIB\Desktop\EF.Demo.2016\EF.DatabaseFirst\bin\Debug\EF.DatabaseFirst.exe</CustomAssemblyPath>
    <CustomTypeName>EF.DatabaseFirst.SchoolDBEntities</CustomTypeName>
    <AppConfigPath>C:\Users\MIB\Desktop\EF.Demo.2016\EF.DatabaseFirst\App.config</AppConfigPath>
  </Connection>
</Query>

var student = (from s in Students.Include("StudentAddress")
					where s.StudentName == "Student1"
					select s).FirstOrDefault();
student.Dump();

using (var ctx = new SchoolDBEntities())
{
    var stud = ctx.Students.Where(s => s.StudentName == "Student1")
                       .Include(s => s.Standard.Teachers)
					   .FirstOrDefault<Student>();
	stud.Dump();
}

//var student1 = (from s in Students.Include("StudentAddress")
//									.Include("Courses")
//					where s.StudentName == "Student1"
//					select s).FirstOrDefault();
//student1.Dump();