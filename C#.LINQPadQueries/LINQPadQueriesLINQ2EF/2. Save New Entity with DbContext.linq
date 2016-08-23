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

Student student = new Student();
student.StudentName = "Student 11";
        
using (var ctx = new SchoolDBEntities())
{
    ctx.Students.Add(student);
    ctx.SaveChanges();
}

//Above code will work in both connected and disconnected scenario to 
//persist new entity as a new row in the database.