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

//fetching existing standard from the db
Standard std = (from s in Standards
				where s.StandardName == "Standart 1"
				select s).FirstOrDefault();

std.StandardName = "Updated standard3";
std.Description = "Updated standard";
std.Dump();
//getting first teacher to be removed
Teacher tchr = std.Teachers.FirstOrDefault();
std.Dump();
//removing teachers (enable cascading delete for the teacher)
if (tchr != null)
	Teachers.Remove(tchr);
std.Dump();

Teacher stdTeacher = std.Teachers.FirstOrDefault();

if (stdTeacher != null)
	stdTeacher.TeacherName = "Updated Teacher";

 Teacher newTeacher = new Teacher();
 newTeacher.TeacherName = "New Teacher";

std.Teachers.Add(newTeacher);
std.Dump();
Teacher existingTeacher = (from t in Teachers
						   where t.StandardId != std.StandardId
						   select t).FirstOrDefault();
std.Dump();SaveChanges().Dump();
if (existingTeacher != null)
	std.Teachers.Add(existingTeacher);