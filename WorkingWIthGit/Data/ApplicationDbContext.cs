using Microsoft.EntityFrameworkCore;
using WorkingWIthGit.Models;

namespace WorkingWIthGit.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; } 
    }
}
