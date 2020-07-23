using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        public DbSet<Contact> Contats { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
