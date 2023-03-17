using System;

namespace StudentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Marks program!");
            Console.WriteLine("Euan McGinness - 22209029 - Student Marks Calculator");

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

            while (true)
            {
                // Display the menu
                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Search for a student");
                Console.WriteLine("2. Display the class average");
                Console.WriteLine("3. Quit");

                // Get the user's choice
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Search for individual students and display their marks
                    Console.Write("Enter the name of the student to search for: ");
                    string searchName = Console.ReadLine();

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
                else if (choice == 2)
                {
                    // Display the class average
                    int totalMarks = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        totalMarks += marks[i];
                    }
                    double average = (double)totalMarks / 10;
                    Console.WriteLine("The class average is {0:F2}", average);
                }
                else if (choice == 3)
                {
                    // Exit the program
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine(); // Add a blank line for readability
            }
        }
    }
}