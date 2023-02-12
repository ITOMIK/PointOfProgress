using System.Collections.Generic;

namespace Point_of_progress.Models
{
    public class TasksPage
    {
     public bool isregistrated { get; set; }
        public List<Task> TaskList { get; set; }
        public List<User> UserList { get; set; }
        public string role { get; set; }
    }
}
