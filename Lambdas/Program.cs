using System;
using System.Collections.Generic;

class Program
{
    delegate int Compute(int x, int y);
    delegate void Print(string msg);
    delegate List<string> GetData(string csvMsg);

    static void Main()
    {
       Func<int,int,int> Add = (int x, int y) => x + y;
       Action<string> Print = (msg) =>
                                        {
                                            string result = $"Welcome" + msg;
                                            Console.WriteLine(result);
                                        };
       Predicate<string> isValidEmail = (email) => email.Contains("@kpmg.com");

        //Invocation
        int result = Add(100, 200);
        Print(result.ToString());
        bool isValid = isValidEmail("abc@kpmg.com");
        Print(isValid.ToString());
    }

    private static int Add(int a, int b) => a + b;
    private static int Sub(int a, int b) => a - b;

    public string Id => "KpMG-" + Guid.NewGuid();

    private static void BitComplexLambda()
    {
        GetData DbData = new GetData((str) => new List<string>() { str });
        //invocation
        List<string> finalList = DbData("meena");
        foreach (var item in finalList)
        {
            Console.WriteLine(item);
        }
    }




    private static void SimpleLambdas()
    {
        //Instantiation
        Print simplePrinter = new Print(DoSomething);
        simplePrinter += DoSomethingMore;
        //invoke delegate
        simplePrinter("Lorem Ipsum");

        Print printer = new Print((msg) => Console.WriteLine(msg));
        printer += (m) => Console.WriteLine($"Print to MS Pdf printer: {m}");

        //invocation
        printer("Quick brown fox jumped over a lazy dog");
    }

    private static void DoSomethingMore(string msg)
    {
        Console.WriteLine("Using another printer");
    }

    private static void DoSomething(string msg)
    {
        Console.WriteLine($"Using Simple Printer: {msg}");
    }
}
