

using Microsoft.EntityFrameworkCore;
using School.Data.Entities;

namespace School.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
                
        }

        public DbSet<Department> Departments { set; get; }


    }
}
