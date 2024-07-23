namespace TaskManagementAPI.Models
{
    public class Task
    {
        public int Id { get; set; } // primary key for the Task entity
        public string Name { get; set; } // name of the task
        public string Description { get; set; } // description of task
        public bool IsCompleted { get; set; } // status of the task

    }
}
