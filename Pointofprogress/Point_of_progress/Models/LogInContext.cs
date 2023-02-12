using Microsoft.EntityFrameworkCore;

namespace Point_of_progress.Models
{
    public class LogInContext: DbContext
    {
        public DbSet<LogIn> LogIns { get; set; }

    public LogInContext(DbContextOptions<LogInContext> options)
         : base(options)
    {
    }
}
}
