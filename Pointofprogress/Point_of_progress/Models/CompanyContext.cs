using Microsoft.EntityFrameworkCore;
namespace Point_of_progress.Models
{
    public class CompanyContext: DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public CompanyContext(DbContextOptions<CompanyContext> options)
             : base(options)
        {
        }
    }
}
