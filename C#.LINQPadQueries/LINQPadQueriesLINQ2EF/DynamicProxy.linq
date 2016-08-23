<Query Kind="Statements">
  <Connection>
    <ID>a67c3694-e9a3-4632-8549-1dca9be0d8b7</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\MIB\Desktop\EFDemo\SchoolDbDemo\bin\Debug\SchoolDbDemo.exe</CustomAssemblyPath>
    <CustomTypeName>SchoolDbDemo.SchoolDBEntities</CustomTypeName>
    <AppConfigPath>C:\Users\MIB\Desktop\EFDemo\SchoolDbDemo\App.config</AppConfigPath>
  </Connection>
</Query>

var query = Courses.FirstOrDefault();
query.GetType().Dump();