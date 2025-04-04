using System;
using System.Collections.Generic;
using ManagerList.TaskItem;
using ManagerList.ManagerTask;

namespace ManagerList
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskList = new List<Tasks>();
            var managerTask = new ManagerTask.ManagerTask();

            taskList.Add(new Tasks("Task 1", "Description 1", DateTime.Now, EStatus.NotStarted));
            taskList.Add(new Tasks("Task 2", "Description 2", DateTime.Now.AddDays(10), EStatus.InProgress));
            taskList.Add(new Tasks("Task 2", "Description 3", DateTime.Now.AddDays(10), EStatus.InProgress));
            taskList.Add(new Tasks("Task 3", "Description 4", DateTime.Now.AddDays(7), EStatus.Completed));

            while (true)
            {
                Console.WriteLine("\n1. To Add Task");
                Console.WriteLine("2. List Task");
                Console.WriteLine("3. Edit Task");
                Console.WriteLine("4. Remove Task");
                Console.WriteLine("5. Go Out");
                Console.Write("Choose an option: ");

                string? option = Console.ReadLine();
                // Console.Clear();
                switch (option)
                {
                    case "1": managerTask.AddToTask(taskList); break;
                    case "2": managerTask.ListTask(taskList); break;
                    case "3": managerTask.EditTask(taskList); break;
                    case "4": managerTask.RemoveTask(taskList); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }
            }
        }
    }
}