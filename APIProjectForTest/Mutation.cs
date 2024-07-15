using APIProjectForTest.Model;
using APIProjectForTest.Repository;

namespace APIProjectForTest
{
    public class Mutation
    {
        public async Task<bool> AddProductAsync([Service] IStudentRepository studentRepository,Student student
            )
        {
            return await studentRepository.SaveAsync(student);
        }

        public async Task<bool> UpdateProductAsync([Service] IStudentRepository studentRepository, Student student)
        {
            return await studentRepository.UpdateProductAsync(student);
        }
        public async Task<bool> DeleteProductAsync([Service] IStudentRepository studentRepository, int Id)
        {
            return await studentRepository.DeleteProductAsync(Id);
        }
    }
}
