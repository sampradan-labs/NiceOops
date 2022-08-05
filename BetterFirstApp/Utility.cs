using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterFirstApp
{
    public class Utility
    {
        public static Int32 Add(Int32 num1, Int32 num2)
        {
            
            return num1 + num2;
        }

        public static int Sub(Int32 num1, Int32 num2)
        {
            return num1 - num2;
        }

        public static int Increment(int num = 0)
        {
            num += 1;   //num=num+1
            num++;
            return num;
        }

        public static bool IsEmpty(string? str, int? num)    //str can accept null
        {
            //&& - AND operator
            //|| - OR operator
            return String.IsNullOrEmpty(str) || num == null;
        }

        public static string[] GetNames()
        {
            //string[] names = new string[3];
            //names[0] = "Eena";
            //names[1] = "Meena";
            //names[2] = "Deeka";

            string[] names = new string[] { "Eena", "Meena", "Deeka" };
            return names;

        }

        public static void GetWordcount(string[] strArray)
        {
            Console.WriteLine($"strArray has {strArray.Length} items in it");
        }


        public static void Createsentence(params string[] strs)
        {
            string sentence = string.Empty;
            foreach (var item in strs)
            {
                sentence += $" {item}";
            }

            Console.WriteLine(sentence);
        }
    }
}
