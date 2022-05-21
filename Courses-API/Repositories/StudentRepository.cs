using Courses_API.Interfaces;
using Courses_API.ViewModels.Student;

namespace Courses_API.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public Task AddStudentAsync(PostStudentViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentViewModel?> GetStudentByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentViewModel>> ListAllStudentsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateStudentAsync(int id, PostStudentViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}