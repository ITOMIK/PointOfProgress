using Microsoft.EntityFrameworkCore;

namespace Point_of_progress.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options)
             : base(options)
        {
        }
    }
}
