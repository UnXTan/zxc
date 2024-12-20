using System;
using System.Collections.Generic;

class Program
{
    static List<Task> tasks = new List<Task>();

    class Task
    {
        public string Description { get; set; }
        public string Comment { get; set; }

        public Task(string description)
        {
            Description = description;
            Comment = string.Empty;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("To-Do List Application");
        while (true)
        {
            Console.WriteLine("\n1. Add Task");
            Console.WriteLine("2. Delete Task");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Add Comment to Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter a task: ");
                string taskDescription = Console.ReadLine();
                tasks.Add(new Task(taskDescription));
                Console.WriteLine("Task added!");
            }
            else if (choice == "2")
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks to delete!");
                    continue;
                }

                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i].Description}");
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
                Console.WriteLine("Tasks:");
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks available.");
                }
                else
                {
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        string comment = string.IsNullOrEmpty(tasks[i].Comment) ? "No comment" : tasks[i].Comment;
                        Console.WriteLine($"{i + 1}. {tasks[i].Description} - Comment: {comment}");
                    }
                }
            }
            else if (choice == "4")
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks to comment on!");
                    continue;
                }

                Console.WriteLine("Tasks:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i].Description}");
                }

                Console.Write("Enter task number to add comment: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
                {
                    Console.Write("Enter your comment: ");
                    string comment = Console.ReadLine();
                    tasks[index - 1].Comment = comment;
                    Console.WriteLine("Comment added!");
                }
                else
                {
                    Console.WriteLine("Invalid task number!");
                }
            }
            else if (choice == "5")
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
