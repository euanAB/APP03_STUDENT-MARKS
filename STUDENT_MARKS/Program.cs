using System;
using System.Numerics;

namespace StudentMarksCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Euan McGinness - 22209029");
            Console.WriteLine("Student Marks Calculator");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Enter the student's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the student's mark: ");
            int mark = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} scored a {1}", name, mark);
            if (mark >= 85)
            {
                Console.WriteLine("Grade: A");
            }
            else if (mark >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else if (mark >= 55)
            {
                Console.WriteLine("Grade: C");
            }
            else if (mark >= 40)
            {
                Console.WriteLine("Grade: D");
            }

            else
            {
                Console.WriteLine("Grade: F");
            }
        }
    }
}