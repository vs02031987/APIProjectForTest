using APIProjectForTest.Model;
using APIProjectForTest.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APIProjectForTest
{
    public class Query
    {
        //private readonly IStudentRepository _studentRepository;
        //public Query(IStudentRepository studentRepository)
        //{
        //    _studentRepository = studentRepository;
        //}
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

        public async Task<List<Student>> GetStudents([Service] IStudentRepository studentRepository)
        {
           return await studentRepository.GetStudentsAsync();
            
        }
        public async Task<Student> GetStudent([Service] IStudentRepository studentRepository, int Id)
        {
          return  await studentRepository.GetStudentAsync(Id);
        }
    }
}
