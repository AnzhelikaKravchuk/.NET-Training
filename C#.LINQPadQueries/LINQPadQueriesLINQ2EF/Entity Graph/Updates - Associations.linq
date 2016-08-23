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

Purchase p1 = new Purchase { ID=100, Description="Bike",  Price=500, Date = DateTime.Now };
Purchase p2 = new Purchase { ID=101, Description="Tools", Price=100, Date = DateTime.Now };

Customer cust = Customers.Single (c => c.ID == 1);

cust.Purchases.Add (p1); 
cust.Purchases.Add (p2);

SubmitChanges();           // Inserts the two purchases and links them to cust

Refresh (RefreshMode.OverwriteCurrentValues, cust);
cust.Purchases.Dump ("cust's purchases, including the two new ones we just inserted");

cust.Purchases.Remove (p1);
cust.Purchases.Remove (p2);

SubmitChanges();           // Unlinks the two purchases

Refresh (RefreshMode.OverwriteCurrentValues, cust);
cust.Purchases.Dump ("After calling EntitySet<>.Remove, notice how the purchases have gone from the customer's collection");

Purchases.Where (p => p.ID == 100 || p.ID == 101)
	.Dump ("The purchases have not been deleted from the table, however: they're still there with a null CustomerID");
	
Purchases.DeleteOnSubmit (Purchases.Single (p => p.ID == 100));
Purchases.DeleteOnSubmit (Purchases.Single (p => p.ID == 101));

SubmitChanges();

Purchases.Dump ("To delete them completely, we must remove them from Table<Purchase> and call SubmitChanges");