using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        internal string Designation { get; set; }
        private string[] CareerGoals { get; set; }
        protected double Salary { get; set; }

        protected static Employee[] GetAll()
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee() { Id = 1, Name = "Parikshit Verma", Designation = "Analyst", Salary = 5000000 };
            employees[1] = new Employee() { Id = 2, Name = "Shruti Shukla", Designation = "QA Manager", Salary = 10000000 };
            return employees;
        }       

        public virtual void PrintDetails()
        {
            Console.WriteLine($"{Name} is a {Designation}. His/her EmpId is {Id}");
        }

        //Only available inside derived class
        protected static double GetSalary(Employee emp)
        {
            return emp.Salary;
        }

        public Employee()
        {
            Salary = 200000;
        }
        public Employee(string[] careerGoals, double salary)
        {
            Salary = salary;
            CareerGoals = careerGoals;
        }

        public void GetPrivateProtectedDetails(string password)
        {
            if (password == "Password@1")
            {
                string result = string.Empty;
                foreach (var goal in CareerGoals)
                {
                    result += $", {goal}";
                }
                Console.WriteLine($"Salary: INR {Salary}, Career Goals: {result}");
            }
            else
            {
                Console.WriteLine($"You are un-authorized to access this info");
            }
            
        }

    }
}
