using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
      class Student
    {
        int rn;
        string name;
        string batch;
        int marks;
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter BAtch");
            batch = Console.ReadLine();
            Console.WriteLine("ENter Score");
            marks = Byte.Parse(Console.ReadLine());

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Rollno is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Batch Code " + batch);
            Console.WriteLine("Marks are "+ marks);
        }
    }
}
