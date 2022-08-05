// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Math Operations
//int type of variable
Int32 num1 = 100;
int num2 = 200;

Console.WriteLine(num1 + num2);
//String interpolation - Concatenate variable value to msg
Console.WriteLine($"The sum of {num1}, {num2} = {num1 + num2}");

Console.WriteLine($"The sume of 100, 200 is {Add(100, 200)}");

//Take value from user
Console.WriteLine("Enter value for num1: ");
string strNum1 = Console.ReadLine();
Console.WriteLine("Enter value for num2: ");
string strNum2 = Console.ReadLine();

num1 = Convert.ToInt32(strNum1);
num2 = Convert.ToInt32(strNum2);
Console.WriteLine ($"The difference between the {num1} and {num2} is : {Sub(num1, num2)}");


Console.WriteLine($"Calling increment without parameter: {Increment()}");
Console.WriteLine($"Calling increment with parameter:{Increment(100)}");

#endregion Math Operations

#region String Operations
Console.WriteLine($" Is null, null empty?: {IsEmpty(null, null)}");
Console.WriteLine($" Is 'Janani', 100 empty?: {IsEmpty("Janani", 100)}");

//Working with Arrays
Console.WriteLine($"Printing all names:");

string[] result = GetNames();


//Passing arrays as parameters
//1.
string[] strArray = new string[] { "Apples","Mangoes", "Bananas" };
GetWordcount(strArray);

//2.
string sentenceParam = "Apples,Mangoes,Bananas,Oranges";
char splitChar = ',';
string[] resultStringArray = sentenceParam.Split(splitChar);
GetWordcount(resultStringArray);

foreach (string item in result )
{
    Console.WriteLine(item);
}


//Using Params keyword
Createsentence("Apples", "Mangoes", "Oranges");
Createsentence("Eena", "Meena");
Console.WriteLine("Enter value for name: ");
string nameParam = Console.ReadLine();
Createsentence("select * from emp", "where name=", nameParam);

#endregion String Operations


#region Method Declarations
static Int32 Add(Int32 num1, Int32 num2)
{
    return num1 + num2;
}

static int Sub(Int32 num1, Int32 num2)
{
    return num1 - num2;
}

static int Increment(int num = 0)
{
    num += 1;   //num=num+1
    num++;
    return num;
}

static bool IsEmpty(string? str, int? num)    //str can accept null
{
    //&& - AND operator
    //|| - OR operator
    return String.IsNullOrEmpty(str) || num == null;
}

static string[] GetNames()
{
    //string[] names = new string[3];
    //names[0] = "Eena";
    //names[1] = "Meena";
    //names[2] = "Deeka";

    string[] names = new string[] { "Eena", "Meena", "Deeka" };
    return names;

}

static void GetWordcount(string[] strArray)
{
    Console.WriteLine($"strArray has {strArray.Length} items in it");
}


static void Createsentence(params string[] strs)
{
    string sentence = string.Empty;
    foreach (var item in strs)
    {
        sentence += $" {item}";
    }

    Console.WriteLine(sentence);
}
#endregion Method Declarations