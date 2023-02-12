using Microsoft.EntityFrameworkCore;

namespace Point_of_progress.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
             : base(options)
        {
        }
    }
}
