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

var stud = (from s in Students
			where s.StudentName == "Student 1"
			select s).FirstOrDefault();

Students.Remove(stud);
SaveChanges().Dump();