using System;
using ManagerList.Enums;

namespace ManagerList.Models
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
    }
}