using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Models;

namespace Repository_Pattern.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {
        }

       public DbSet<Student> Students { get; set; }
    }
}
