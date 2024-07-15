using APIProjectForTest.Model;

namespace APIProjectForTest.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentAsync(int Id);
        Task<List<Student>> GetStudentsAsync();
        Task<bool> SaveAsync(Student student);
        Task<bool> UpdateProductAsync(Student student);
        Task<bool> DeleteProductAsync(int Id);       
       
    }
}
