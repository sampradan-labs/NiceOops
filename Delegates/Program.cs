using System;

namespace Delegates
{
    class Program
    {
        //declaration
        delegate void Compute(int n1, int n2);
        delegate void Manager(string[] tasks);
        static void Main()
        {
            //instantiation
            Manager mgrHarshvardhan = new Manager(devParth);
            mgrHarshvardhan += testerJanani;
            mgrHarshvardhan += deployParikshit;

            //invocation
            Console.WriteLine("Requesting Client to add tasks (,) separated");
            var clientInput = Console.ReadLine();
            //Delegate tasks to Developer, tester, deployment engg
            mgrHarshvardhan(clientInput.Split(','));
        }

        private static void deployParikshit(string[] tasks)
        {
            string isCompleted = "Completed";
            foreach (string task in tasks)
            {
                Console.WriteLine($"Deployment of Task {task} is {isCompleted}");
                if (isCompleted == "Completed")
                {
                    isCompleted = "InProgress";
                }
                else
                {
                    isCompleted = "Completed";
                }
                
            }
        }

        private static void testerJanani(string[] tasks)
        {
            string isCompleted = "Completed";
            foreach (string task in tasks)
            {
                Console.WriteLine($"Testing of Task {task} is {isCompleted}");
                if (isCompleted == "Completed")
                {
                    isCompleted = "InProgress";
                }
                else
                {
                    isCompleted = "Completed";
                }

            }
        }

        private static void devParth(string[] tasks)
        {
            string isCompleted = "Completed";
            foreach (string task in tasks)
            {
                Console.WriteLine($"Coding for Task {task} is {isCompleted}");
                if (isCompleted == "Completed")
                {
                    isCompleted = "InProgress";
                }
                else
                {
                    isCompleted = "Completed";
                }

            }
        }

        private static void SimpleDelegate()
        {
            //Instantiation
            Compute calculator = new Compute(Add);
            calculator += Sub;
            calculator += Mul;
            calculator += Divide;

            //Invocation
            calculator(100, 200);
        }

        private static void Divide(int n1, int n2)
        {
            Console.WriteLine($"Division of {n1}/{n2} = {n1 / n2}");
        }

        private static void Mul(int n1, int n2)
        {
            Console.WriteLine($"Product of {n1}*{n2} = {n1 * n2}");
        }

        private static void Sub(int n1, int n2)
        {
            Console.WriteLine($"Difference between {n1}-{n2} = {n1 - n2}");
        }

        private static void Add(int n1, int n2)
        {
            Console.WriteLine($"Sum of {n1}+{n2} = {n1 + n2}");
        }
    }
}