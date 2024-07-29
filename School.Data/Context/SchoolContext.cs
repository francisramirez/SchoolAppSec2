

using Microsoft.EntityFrameworkCore;
using School.Data.Entities;

namespace School.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
                
        }
        public SchoolContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("SchoolDb");
        }

        public DbSet<Department> Departments { set; get; }

        public DbSet<Course> Courses { set; get; }
    }
}
