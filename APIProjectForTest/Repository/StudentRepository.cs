using APIProjectForTest.DBContexts;
using APIProjectForTest.Model;
using Microsoft.EntityFrameworkCore;

namespace APIProjectForTest.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _dbContext;
        public StudentRepository(StudentContext dbContext)
        {
            _dbContext= dbContext;
        }
        public async Task<Student> GetStudentAsync(int Id)
        {
            return await _dbContext.Students?.Where(ele => ele.Id == Id).FirstOrDefaultAsync();
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }      

        public async Task<bool> SaveAsync(Student student)
        {
            await _dbContext.Students.AddAsync(student);
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProductAsync(Student student)
        {
            var isProduct = ProductDetailsExists(student.Id);
            if (isProduct)
            {
                _dbContext.Students.Update(student);
                var result = await _dbContext.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public async Task<bool> DeleteProductAsync(int Id)
        {
            var findProductData = _dbContext.Students.Where(_ => _.Id == Id).FirstOrDefault();
            if (findProductData != null)
            {
                _dbContext.Students.Remove(findProductData);
                var result = await _dbContext.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        private bool ProductDetailsExists(int Id)
        {
            return _dbContext.Students.Any(e => e.Id == Id);
        }
    }
}
