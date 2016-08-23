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

Student student = new Student();
student.StudentName = "Student 2";

Standard std = new Standard();
std.StandardName = "Standard 2";

student.Standard = std;

StudentAddress sAddress = new StudentAddress();

sAddress.Address1 = "Address 1";
sAddress.Address2 = "Address 2";
sAddress.City = "City 1";
sAddress.State = "State 1";

student.StudentAddress = sAddress;
Students.Add(student);
SaveChanges().Dump("saved entity:");