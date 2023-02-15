using Microsoft.EntityFrameworkCore;

namespace TestNotissimus.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
