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
            Console.WriteLine("2. Delete Task");
            Console.WriteLine("3. Exit");
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
                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }

                Console.Write("Enter task number to delete: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine("Task deleted!");
                }
                else
                {
                    Console.WriteLine("Invalid task number!");
                }
            }
            else if (choice == "3")
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
