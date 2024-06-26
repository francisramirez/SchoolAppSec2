

using Microsoft.EntityFrameworkCore;
using School.Data.Entities;

namespace School.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options):base(options)
        {
                
        }

        public DbSet<Department> Departments { set; get; }


    }
}
