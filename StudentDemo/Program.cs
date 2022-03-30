using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Only declaration
            //Student student;
            //student = new Student();
            //Student student = new Student();
            //student.GetDetails();
            //student.DisplayDetails();

            //Student student1 = new Student();
            //student1.GetDetails();
            //student1.DisplayDetails();
            //Student student2 = new Student();
            //student2.GetDetails();
            // Array of objects
            Student[] students = new Student[10];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Details for Student No {i + 1}");
                students[i] = new Student();
                students[i].GetDetails();
            }

            Console.WriteLine("Details are ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Details of Student No {i+ 1}");

                students[i].DisplayDetails();
            }
             


        }
    }
}
