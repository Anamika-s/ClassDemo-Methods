using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class MethodReturnsMoreValues
    {
        static void Main()
        {
        
            Console.WriteLine(Add(1,2));

            // Calling Part 
            int add, subtract, prod, rem;
            Operations(10, 6, out add, out subtract, out prod, out rem);
            Console.WriteLine("Sum is " + add);
            Console.WriteLine("Difference is " + subtract);
            Console.WriteLine("Product is " + prod);
            Console.WriteLine("Remainder is " + rem);
        
        
        
        
        }
        static int Add(int x, int y)
        {
            return x + y;
        }

        // A function can returm more than 1 value using output paramerters
        // WAF to  find sum , difference , product, rem of 2 numbers


        static void Operations(
            int x, int y,
            out int add,
            out int difference,
            out int product,
            out int rem)
        {
            add = x + y;
            difference = x - y;
            product = x * y;
            rem = x % y;
        }
    }
}
