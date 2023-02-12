using ASPDOTNETBOLMVC6.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPDOTNETBOLMVC6.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {


        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
