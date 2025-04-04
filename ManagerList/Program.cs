using System;
using System.Collections.Generic;
using ManagerList.TaskItem;

namespace ManagerList
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskList = new List<Tasks>();
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
                    case "1": AddToTask(taskList); break;
                    case "2": ListTask(taskList); break;
                    case "3": EditTask(taskList); break;
                    case "4": RemoveTask(taskList); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid option. Please try again."); break;
                }
            }
        }

        static void ListTask(List<Tasks> taskList)
        {
            Console.WriteLine("To-Do List:");

            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            foreach (var task in taskList)
            {
                Console.WriteLine($"ID: {task.Id}, Nome: {task.TaskName}, Descrição: {task.TaskDescription}, Prazo: {task.DueDate.ToShortDateString()}, Status: {task.Status}");
            }
        }

        static void AddToTask(List<Tasks> taskList)
        {
            Console.Write("Name Task: ");
            string taskName = Console.ReadLine() ?? string.Empty;

            Console.Write("Description Task: ");
            string taskDescription = Console.ReadLine() ?? string.Empty;

            Console.Write("Term (dd/MM/yyyy): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);

            EStatus status = EStatus.NotStarted; // Definindo o status padrão como "Não Começou".

            var newTask = new Tasks(taskName, taskDescription, dueDate, status);
            taskList.Add(newTask);
        }

        static void EditTask(List<Tasks> taskList)
        {
            Console.Write("ID of the Task to be edited or digit 'S' for go out: ");
            string taskId = Console.ReadLine() ?? string.Empty;

            // Encontrar a tarefa pelo ID
            var taskFound = taskList.Find(t => t.Id == taskId);
            if (taskId.ToUpper() == "S")
            {
                Console.WriteLine("Operation canceled.");
                return;
            }
            else if (string.IsNullOrEmpty(taskId) || taskFound == null)
            {
                Console.WriteLine("Task not found. Please check the ID and try again.");
                return;
            }
            else
            {
                while (true)
                {
                    Console.WriteLine($"What do you want to edit in {taskFound.TaskName}?");
                    Console.WriteLine("1. Task Name");
                    Console.WriteLine("2. Task Description");
                    Console.WriteLine("3. Task Due Date");
                    Console.WriteLine("4. Task Status");
                    Console.WriteLine("5. Go Out");
                    Console.Write("Choose an option: ");
                    // Console.Clear();

                    string? option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.Write("New Task Name: ");
                            taskFound.TaskName = Console.ReadLine() ?? string.Empty;
                            break;
                        case "2":
                            Console.Write("New Task Description: ");
                            taskFound.TaskDescription = Console.ReadLine() ?? string.Empty;
                            break;
                        case "3":
                            Console.Write("New Task Due Date (dd/MM/yyyy): ");
                            taskFound.DueDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);
                            break;
                        case "4":
                            Console.Write("New Task Status (NotStarted, InProgress, Completed): ");
                            taskFound.Status = (EStatus)Enum.Parse(typeof(EStatus), Console.ReadLine() ?? string.Empty);
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }
        }

        static void RemoveTask(List<Tasks> taskList)
        {
            Console.Write("Task ID to be deleted: ");
            string taskId = Console.ReadLine() ?? string.Empty;

            // Encontrar a tarefa pelo ID
            var taskFound = taskList.Find(t => t.Id == taskId);
            if (taskFound == null)
            {
                Console.WriteLine("Task not found. Please check the ID and try again.");
                return;
            }
            else
            {
                taskList.Remove(taskFound);
                Console.WriteLine($"Task {taskFound.TaskName} removed successfully.");
            }

        }
    }
}