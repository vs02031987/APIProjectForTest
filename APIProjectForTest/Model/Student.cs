namespace APIProjectForTest.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Course CourseName { get; set; }

    }
    public enum Course {
        Math,
        Biology,
        Commerce
    }
}
