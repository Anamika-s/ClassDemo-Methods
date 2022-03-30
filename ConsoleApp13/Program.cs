using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {

        // Functions : Modularity
        // Breaking a big program into smaller subprograms
        // functions 
        // Advantage of functions
        // 1. Resuablity
        //2 . Modularity
        //3. Easy to understand , maintain, debug small program
        static int num1, num2;
        static int ch;
        static void Main(string[] args)
        {

            GetValues_Choice();


        }
        static void GetValues_Choice()
        {
            Console.WriteLine("Enter No1");
            num1 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter No2");
            num2 = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Choice");
            ch = Byte.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Add();
                    break;
                case 2: 
                    Differnce();
                    break;

            }
        }

        static void Add()
        {
            Console.WriteLine($"Sum of {num1} & {num2} is {num1 + num2}");

        }
        static void Differnce()
        {
            Console.WriteLine($"DIfference of {num1} & {num2} is {num1 - num2}");

        }
    }
}
