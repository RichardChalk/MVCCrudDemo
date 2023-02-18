using Microsoft.EntityFrameworkCore;

namespace MVCCrudDemo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
