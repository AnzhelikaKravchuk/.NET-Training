<Query Kind="Statements">
  <Connection>
    <ID>c1aeac61-b72c-4374-8b36-d07566fdaa1f</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\MIB\Desktop\EF.Demo.2016\EF.DatabaseFirst\bin\Debug\EF.DatabaseFirst.exe</CustomAssemblyPath>
    <CustomTypeName>EF.DatabaseFirst.SchoolDBEntities</CustomTypeName>
    <AppConfigPath>C:\Users\MIB\Desktop\EF.Demo.2016\EF.DatabaseFirst\App.config</AppConfigPath>
  </Connection>
  <Reference>C:\Users\MIB\Desktop\ASP.NET MVC 4 Training Spring 2014\Day 13\EntityFrameworkExamples\SchoolDemo\bin\Debug\EntityFramework.dll</Reference>
</Query>

Student student = new Student();
student.StudentName = "student 1";

Standard std = new Standard();
std.StandardName = "standard 1";
std.Description = "Demo standard";

student.Standard = std;

Course course1 = new Course();
course1.CourseName = "Course 1 ";

Course course2 = new Course();
course2.CourseName = "Course 2 ";

Course course3 = new Course();
course3.CourseName = "Course 3 ";

Teacher teacher1 = new Teacher();
teacher1.TeacherName = "teacher 1";
teacher1.Standard = std;

//assign teacher1 for each courses
course1.Teacher = teacher1;
course2.Teacher = teacher1;
course3.Teacher = teacher1;

//Add courses to student
student.Courses.Add(course1);
student.Courses.Add(course2);
student.Courses.Add(course3);

//add whole student entity graph to context
Students.Add(student);
SaveChanges().Dump("saved entity:");