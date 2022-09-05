using Microsoft.EntityFrameworkCore;
using prjAspNet6.Models;

namespace prjAspNet6.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> categories { get; set; }
    }
}
