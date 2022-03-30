using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class CallByValue
    {
        static void Main()
        {
            int x = 100;
            Console.WriteLine("Value of x in Main before Calling Change1 " + x);
            Change1(x);
            Console.WriteLine("Value of x in Main after calling Change1 " + x);


        }
        static void Change1(int x)
        {
            Console.WriteLine("Value of x in Change1 is " + x);
            x = 200;
            Console.WriteLine("Value of x in Change1 is " + x);
        }
        static void Change2()
        {

        }
    }
}
