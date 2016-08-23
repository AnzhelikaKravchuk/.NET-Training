<Query Kind="Statements">
  <Connection>
    <ID>85eac0e8-600e-48e1-8ef9-78e00b500c83</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\MIB\Desktop\EFDatabaseFirstDemo2016\bin\Debug\EFDatabaseFirstDemo2016.exe</CustomAssemblyPath>
    <CustomTypeName>EFDatabaseFirstDemo2016.SchoolDBEntities</CustomTypeName>
    <AppConfigPath>C:\Users\MIB\Desktop\EFDatabaseFirstDemo2016\App.config</AppConfigPath>
  </Connection>
</Query>

var student = from s in Students
				orderby s.StudentName ascending
				select s;
				
student.Dump();