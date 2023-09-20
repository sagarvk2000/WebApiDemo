using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Entities
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
