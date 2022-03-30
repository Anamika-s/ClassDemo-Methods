using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Methods
    {
        static void Main()
        {
            DispalyDetails("A", "B", 9000);
            //DispalyDetails("Hr", "Ajay", 9000);

            // Named Parameters
            DispalyDetails(dept: "HR", name: "Ajay", salary: 9000);
            DispalyDetails(salary: 90000, name: "Ajay", dept: "HR");
            SI(10000, 2, 9);
            SI(10000, 2);
            SI(10000);
            SI();

        }
        static void DispalyDetails(string name, string dept, int salary)
        {
            Console.WriteLine($"Name is {name} Dept is {dept} Salary is {salary}");
        }

        // Optional Parameters
        static void SI(int principal=15000, int rate=9 , int time=5)
        {
            int si =(principal * rate * time) / 100;
            Console.WriteLine($"SI is {si}");
        }


    }
}
