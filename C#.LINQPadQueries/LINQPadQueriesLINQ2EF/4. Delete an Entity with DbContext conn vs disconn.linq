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

//Connected scenario:
// 
// {
// using (var ctx = new SchoolDBEntities())
//{
//    var stud = (from s in ctx.Students
//                where s.StudentName == "student 1"
//                select s).FirstOrDefault();
//
//    ctx.Students.Remove(stud);
//
//    int num = ctx.SaveChanges();
//}}

//Disconnected scenario:
{Student stud = null;

using (var ctx = new SchoolDBEntities())
{
    stud = (from s in ctx.Students
            where s.StudentName == "Student1"
            select s).FirstOrDefault();
}

using (var newCtx = new SchoolDBEntities())
{
    newCtx.Students.Attach(stud);
    newCtx.Students.Remove(stud);
    int num = newCtx.SaveChanges();
}}