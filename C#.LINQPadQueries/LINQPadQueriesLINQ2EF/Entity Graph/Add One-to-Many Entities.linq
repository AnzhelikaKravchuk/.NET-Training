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

Standard std = new Standard();

std.StandardName = "Standard 1";
std.Description = "Demo standard";

Teacher teacher1 = new Teacher();
teacher1.TeacherName = "Teacher 1";

Teacher teacher2 = new Teacher();
teacher2.TeacherName = "Teacher 2";

Teacher teacher3 = new Teacher();
teacher3.TeacherName = "Teacher 3";

//Adding many teachers for one standard
std.Teachers.Add(teacher1);
std.Teachers.Add(teacher2);
std.Teachers.Add(teacher3);

Standards.Add(std);
SaveChanges().Dump("saved entity:");