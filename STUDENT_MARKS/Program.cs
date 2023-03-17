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
                Console.WriteLine("2. Update a student's marks");
                Console.WriteLine("3. Display the class average");
                Console.WriteLine("4. Display each student's mark percentage");
                Console.WriteLine("5. Quit");

                // Get the user's choice
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Search for individual students and display their marks and class
                    Console.Write("Enter the name of the student to search for: ");
                    string searchName = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (names[i].ToLower() == searchName.ToLower())
                        {
                            Console.WriteLine("{0} has {1} marks", names[i], marks[i]);

                            // Determine the grade/class based on the marks
                            if (marks[i] >= 70 && marks[i] <= 100)
                            {
                                Console.WriteLine("Grade: A (First Class)");
                            }
                            else if (marks[i] >= 60 && marks[i] <= 69)
                            {
                                Console.WriteLine("Grade: B (Upper Second Class)");
                            }
                            else if (marks[i] >= 50 && marks[i] <= 59)
                            {
                                Console.WriteLine("Grade: Lower Second Class");
                            }
                            else if (marks[i] >= 40 && marks[i] <= 49)
                            {
                                Console.WriteLine("Grade: D (Third Class)");
                            }
                            else
                            {
                                Console.WriteLine("Grade: F (Fail)");
                            }

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
                    // Update a student's marks
                    Console.Write("Enter the name of the student to update: ");
                    string updateName = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < 10; i++)
                    {
                        if (names[i].ToLower() == updateName.ToLower())
                        {
                            Console.Write("Enter the new marks for {0}: ", names[i]);
                            marks[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine("{0}'s marks have been updated to {1}", names[i], marks[i]);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Student not found");
                    }
                }
                else if (choice == 3)
                {
                    // Display the class average
                    int totalMarks = 0;
                    for (int i = 0; i < 10; i++)
                    {
                    }
                }
            }
        }
    }
}

