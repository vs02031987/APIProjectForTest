using APIProjectForTest.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APIProjectForTest
{
    public class Query
    {
        public Book GetBook()
        {
            return new Book
            {
                Title = "C# in depth.",
                Author = new Author
                {
                    Name = "Jon",
                    Publication = "Arihant 123"
                }
            };
        }

        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student()
                {
                   Id = 1,  
                   Name="John",
                   Age = 16,
                   Gender="M",
                   CourseName= Course.Math
                },
                 new Student()
                {
                   Id = 2,
                   Name="Sunny",
                   Age = 17,
                   Gender="F",
                   CourseName= Course.Biology
                },
                 new Student()
                {
                   Id = 3,
                   Name="Mac",
                   Age = 17,
                   Gender="M",
                   CourseName= Course.Commerce
                }

            };
        }
        public Student GetStudent(int id)
        {
            var studentdata = new List<Student>
            {
                new Student()
                {
                   Id = 1,
                   Name="John Buttler",
                   Age = 16,
                   Gender="M",
                   CourseName= Course.Math
                },
                 new Student()
                {
                   Id = 2,
                   Name="Sunny teris",
                   Age = 17,
                   Gender="F",
                   CourseName= Course.Biology
                },
                 new Student()
                {
                   Id = 3,
                   Name="Mac",
                   Age = 17,
                   Gender="M",
                   CourseName= Course.Commerce
                }

            }.FirstOrDefault(x => x.Id == id);
            if (studentdata != null)
                return studentdata;
            return null;
        }
    }
}
