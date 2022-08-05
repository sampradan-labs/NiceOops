using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Relatives
    {
        /// <summary>
        /// Just time-pass gossip about Kpmg Salaries of employees
        /// </summary>
        public void Gossip()
        {
            Employee Parikshit = new Employee();
            AccountsExecutive ParikshitsAccExec = new AccountsExecutive();
            Console.WriteLine("** Salary, GetSalary are protected entities of Employee Class" +
                                $"{Environment.NewLine} Hence, cannot be accessed by Relatives **");
            Parikshit.PrintDetails();   //salary (protected) not available
            ParikshitsAccExec.PrintDetails();   //salary (protected) for Parikshit not available.
        }
    }

    internal class Auditor
    {
        public void PrintAccounts()
        {
            AccountsExecutive KpmgFinanceTeam = new AccountsExecutive();
            KpmgFinanceTeam.PrintDetails();
        }
    }
}
