// See https://aka.ms/new-console-template for more information
using Encapsulation;

//To access private or protected members, create a public method or parameter in constructor
Employee Parth = new Employee(new string[] {"I dont know", "Will decide later"}, 5000000);
Parth.GetPrivateProtectedDetails("idontknow");
Parth.GetPrivateProtectedDetails("Password@1");












/// <summary>
/// AccountsExecutive INHERITS Employee.
/// Hence can access Protected Members ONLY inside its methods
/// </summary>
AccountsExecutive KpmgFinanceTeam = new AccountsExecutive();
KpmgFinanceTeam.PrintDetails();












/// <summary>
/// Classes which not in inheritance relationship with below
/// </summary>
Relatives ParthRelatives = new Relatives();
ParthRelatives.Gossip();

Auditor KpmgAuditor = new Auditor();
KpmgAuditor.PrintAccounts();


