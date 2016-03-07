using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomStringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("devCodeCamp");
            CustomMethods customMethods = new CustomMethods();

            string str1 = customMethods.ToUpperCase("This is a String!");
            Console.WriteLine(str1);

            string str2 = customMethods.ToLowerCase("This is a String!");
            Console.WriteLine(str2);

            customMethods.Split("This is a String!");

            bool contains = customMethods.CustomContains("This is a string", 'z');
            Console.WriteLine(contains);

            int count = customMethods.CustomCount("This is a string!");
            Console.WriteLine(count);

            customMethods.CustomReplace("This is a string", 's', 'z');



            Console.ReadKey();

        }
    }
}
