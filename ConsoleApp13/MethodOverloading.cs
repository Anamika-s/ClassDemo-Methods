using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class WithoutMethodOverloading
    {
        static void Main()
        {
            Add1(10, 20);
            Add4(2.6f, 3.8f);
            Add5("This", "is C#");

        }
        static void Add1(int x, int y)
        {
            Console.WriteLine("Sum is " + (x + y));

        }

        static void Add2(int x, int y, int z)
        {
            Console.WriteLine("Sum is " + (x + y + z));

        }

        static void Add3(int x, float y)
        {
            Console.WriteLine("Sum is " + (x + y));

        }

        static void Add4(float x, float y)
        {
            Console.WriteLine("Sum is " + (x + y));

        }

        static void Add5(string x, string y)
        {
            Console.WriteLine(x +" " + y);

        }



    }

    class WithMethodOverloading
    {
        static void Main()
        {
            Add("A", "B");
        }
        static void Add(int x, int y)
        {
            Console.WriteLine("Sum is " + (x + y));

        }

        //static int Add(int x, int y)
        //{
        //    Console.WriteLine("Sum is " + (x + y));

        //}

        static void Add(int x, int y, int z)
        {
            Console.WriteLine("Sum is " + (x + y + z));

        }

        static void Add(int x, float y)
        {
            Console.WriteLine("Sum is " + (x + y));

        }

        static void Add(float x, float y)
        {
            Console.WriteLine("Sum is " + (x + y));

        }

        static void Add(string x, string y)
        {
            Console.WriteLine(x + " " + y);

        }



    }
}
