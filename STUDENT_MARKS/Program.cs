using System;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Marks program!");
            Console.WriteLine("Euan McGinness - 22209029 - Student Marks Calculator");
            Console.WriteLine("You will be asked to enter the names and marks of 10 students,");
            Console.WriteLine("and then you can search for individual students and see their marks.");
            {
            string[] names = new string[10];
            int[] marks = new int[10];

            // Get input from user for names and marks
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the name of student #{0}: ", i + 1);
                names[i] = Console.ReadLine();

                Console.Write("Enter the marks of student #{0}: ", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
            }

            // Search for individual students and display their marks
            while (true)
            {
                Console.Write("Enter the name of the student to search for (or 'quit' to exit): ");
                string searchName = Console.ReadLine();

                if (searchName.ToLower() == "quit")
                {
                    break;
                }

                bool found = false;
                for (int i = 0; i < 10; i++)
                {
                    if (names[i].ToLower() == searchName.ToLower())
                    {
                        Console.WriteLine("{0} has {1} marks", names[i], marks[i]);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found");
                }
            }
        }
    }
}
