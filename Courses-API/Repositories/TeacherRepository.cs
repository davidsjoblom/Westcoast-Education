using Courses_API.Interfaces;
using Courses_API.ViewModels.Teacher;

namespace Courses_API.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public Task AddTeacherAsync(PostTeacherViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTeacherAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherViewModel?> GetTeacherByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TeacherViewModel>> ListAllTeachersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTeacherAsync(int id, PostTeacherViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}