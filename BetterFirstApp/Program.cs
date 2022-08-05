using BetterFirstApp;
using System;
using OopsBL;

namespace BetterFirstApp
{

    class Program
    {
        
        public static void Main()
        {
            Rectangle rh = new Rhombus() { Angle = 30};
            rh.Length = 10;
            rh.Breadth = 10;
            //rh.Angle = 30;
            rh.CalculateArea();
        }

        private static void SwitchCase()
        {
            object shape = null;

            do
            {
                Console.WriteLine("Which shape should we construct? ");
                string input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "rectangle":
                        shape = new Rectangle(10, 5);
                        (shape as Rectangle).CalculateArea();
                        Console.WriteLine($"Rectangle drawn with area= {((Rectangle)shape).CalculateArea()}");
                        break;

                    case "square":
                        shape = new Square(5);
                        (shape as Square).CalculateArea();
                        Console.WriteLine($"Square drawn with area= {((Square)shape).CalculateArea()}");
                        break;

                    default:
                        throw new Exception("Invalid Shape");

                }
                Console.WriteLine("Do you wish to continue creating shapes? ");

            } while (Console.ReadLine().ToLower() != "n");
        }

        private static void NewObjects()
        {
            //string[] arr = new string[] { "" };
            Rectangle r1 = new Rectangle();
            r1.Length = 10;
            r1.Breadth = 5;
            Console.WriteLine($"Area of r1 = {r1.CalculateArea()}");

            r1 = new Rectangle();
            Console.WriteLine($"Length: {r1.Length} | Breadth = {r1.Breadth}");

            var s1 = new Square(5);
            Console.WriteLine($"Area: {s1.CalculateArea()}");
        }

        private static void FunWithMethods()
        {
            Console.WriteLine($"Add:{Utility.Add(100, 200)}");
            Console.WriteLine($"Subtract: {Utility.Sub(100, 200)}");
            Console.WriteLine($"Increment: {Utility.Increment(100)}");

            var names = "Eena,Meena,Deeka".Split(',');
            Utility.GetWordcount(names);

            Utility.Createsentence("select * from emp", "where name='Meena'");
        }
    }

}