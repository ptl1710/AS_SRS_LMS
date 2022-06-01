using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Class { get; set; }
    }
}
