using APIProjectForTest.Model;
using Microsoft.EntityFrameworkCore;

namespace APIProjectForTest.DBContexts
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students
        { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>().HasData(
        //    new List<Student>
        //    {
        //        new Student()
        //        {
        //           Id = 1,
        //           Name="John",
        //           Age = 16,
        //           Gender="M",
        //           CourseName= Course.Math
        //        },
        //         new Student()
        //        {
        //           Id = 2,
        //           Name="Sunny",
        //           Age = 17,
        //           Gender="F",
        //           CourseName= Course.Biology
        //        },
        //         new Student()
        //        {
        //           Id = 3,
        //           Name="Mac",
        //           Age = 17,
        //           Gender="M",
        //           CourseName= Course.Commerce
        //        }
        //    }

         
        //    );
        //}
    }
}
