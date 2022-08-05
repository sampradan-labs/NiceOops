// See https://aka.ms/new-console-template for more information
using Interfaces;

Console.WriteLine("Hello, World!");
Console.WriteLine("#### KPMG COMPANY ####");
Console.WriteLine("Purchasing software licenses of type IDbms");

List<IDbms> dbmsLicenses = new List<IDbms>();
dbmsLicenses.Add(new SqlServer() { DbInstance = "Express", SqlLanguage="Ms SQL"});
dbmsLicenses.Add(new SqlServer() { DbInstance = "Developer", SqlLanguage = "Ms SQL + Reporting" });
dbmsLicenses.Add(new MongoDb() { DbInstance = "Enterprise", SqlLanguage = "Json" });
dbmsLicenses.Add(new MongoDb() { DbInstance = "Ultimate", SqlLanguage = "Json+Xml" });

foreach (var db in dbmsLicenses)
{
    Console.WriteLine($"License key: {db.LicenseKey} | Sql Language: {db.SqlLanguage}");
}