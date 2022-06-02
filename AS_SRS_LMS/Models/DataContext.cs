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
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<TestSchedule> TestSchedules { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}
