using System.ComponentModel.DataAnnotations;

namespace APIProjectForTest.Model
{
    public class Student
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        public int Age { get; set; }
        [MaxLength(10)]
        public string? Gender { get; set; }
        public Course CourseName { get; set; }

    }
    public enum Course {
        Math=1,
        Biology=2,
        Commerce=3
    }
}
