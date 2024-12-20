using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        Console.WriteLine("To-Do List Application");
        while (true)
        {
            Console.WriteLine("\n1. Add Task");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter a task: ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.WriteLine("Task added!");
            }
            else if (choice == "2")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
