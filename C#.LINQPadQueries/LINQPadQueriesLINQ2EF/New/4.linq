<Query Kind="Statements">
  <Connection>
    <ID>a67c3694-e9a3-4632-8549-1dca9be0d8b7</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\MIB\Desktop\EFDemo\SchoolDbDemo\bin\Debug\SchoolDbDemo.exe</CustomAssemblyPath>
    <CustomTypeName>SchoolDbDemo.SchoolDBEntities</CustomTypeName>
    <AppConfigPath>C:\Users\MIB\Desktop\EFDemo\SchoolDbDemo\App.config</AppConfigPath>
  </Connection>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.dll</Reference>
  <Namespace>System.Collections.ObjectModel</Namespace>
  <Namespace>System.Runtime.Serialization</Namespace>
  <Namespace>System.Runtime.Serialization.Json</Namespace>
  <Namespace>System.Xml.Serialization</Namespace>
</Query>

using (var con = new EntityConnection("name=SchoolDBEntities"))
    {
        con.Open();
        EntityCommand cmd = con.CreateCommand();
        cmd.CommandText = "SELECT VALUE st FROM SchoolDBEntities.Students as st where st.StudentName='Student1'";
        Dictionary<int, string> dict = new Dictionary<int, string>();
        using (EntityDataReader rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess | CommandBehavior.CloseConnection))
        {
                while (rdr.Read())
                {
                    int a = rdr.GetInt32(0);
                    var b = rdr.GetString(1);
                    dict.Add(a, b);
                }
        }      
		dict.Dump();
    }