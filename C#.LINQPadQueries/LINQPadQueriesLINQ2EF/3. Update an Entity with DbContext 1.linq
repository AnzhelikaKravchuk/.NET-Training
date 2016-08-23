<Query Kind="Statements">
  <Connection>
    <ID>a67c3694-e9a3-4632-8549-1dca9be0d8b7</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\MIB\Desktop\EFDemo\SchoolDbDemo\bin\Debug\SchoolDbDemo.exe</CustomAssemblyPath>
    <CustomTypeName>SchoolDbDemo.SchoolDBEntities</CustomTypeName>
    <AppConfigPath>C:\Users\MIB\Desktop\EFDemo\SchoolDbDemo\App.config</AppConfigPath>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Dynamic.dll</Reference>
  <IncludePredicateBuilder>true</IncludePredicateBuilder>
</Query>

using (var ctx = new SchoolDBEntities())
{
    var student = new Student{ StudentID = 1};
    ctx.Students.Attach(student);
	student.StudentName = "Student 1";
	ctx.SaveChanges();
}