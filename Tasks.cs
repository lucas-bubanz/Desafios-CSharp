using System;
using System.Collections.Generic;
// using ManagerList.TaskItems;

namespace ManagerList.TaskItem
{
    public class Tasks
    {
        public string Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime DueDate { get; set; }
        public EStatus Status { get; set; }

        public Tasks(string taskName, string taskDescription, DateTime dueDate, EStatus status)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 8);
            TaskName = taskName;
            TaskDescription = taskDescription;
            DueDate = dueDate;
            Status = status;
        }

        // public enum Estatus
        // {
        //     NotStarted = 0,
        //     InProgress = 1,
        //     Completed = 2
        // }
    }
}