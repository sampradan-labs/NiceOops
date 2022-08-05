// See https://aka.ms/new-console-template for more information
using Encapsulation;
using System.Collections;

Console.WriteLine("Hello, World!");
string[] strArr = new string[3];
ArrayList arrList = new ArrayList();
arrList.Add("Meena");
arrList.Add(1000);
arrList.Add(true);
arrList.Add(new string[] { "Apples", "Mangoes" });
arrList[0] = "Teena";
arrList.Remove(1000);

string strResult = string.Empty;
foreach (var item in arrList)
{
   strResult += item;
    Console.WriteLine(strResult);
}

List<string> strlist = new List<string>();
strlist.Add("Meena");
strlist.AddRange(new List<string> { "Sushma", "Pratap", "Neeral" });
strlist.Remove("Sushma");
strlist[0] = "Sheena";
foreach (var item in strlist)
{
    Console.WriteLine($"Value of item: {item}");
}

ICollection<Employee> kpmgEmployees = new List<Employee>();
kpmgEmployees.Add(new Employee() { Id=1, Name="Shruti Shukla"});
kpmgEmployees.Add(new Employee() { Id = 2, Name = "Preetam" });
kpmgEmployees.Add(new Employee() { Id = 3, Name = "Parth" });
kpmgEmployees.Add(new Employee() { Id = 4, Name="Murali"});
kpmgEmployees.Add(new Employee() { Id=5, Name= "Parikshit"});
kpmgEmployees.Add(new Employee() { Id = 6, Name = "Janani" });
kpmgEmployees.Add(new Employee() { Id = 7, Name = "Srishti" });

foreach (var emp in kpmgEmployees)
{
    Console.WriteLine($"Id: {emp.Id} | Name: {emp.Name}");
}























