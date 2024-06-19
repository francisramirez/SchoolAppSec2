

using Microsoft.EntityFrameworkCore;

namespace School.Data.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {
                
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("DbSchool");
        }


    }
}
