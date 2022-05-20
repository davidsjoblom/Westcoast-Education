using Courses_API.Interfaces;
using Courses_API.ViewModels.Course;

namespace Courses_API.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public Task AddCourseAsync(PostCourseViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCourseAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseViewModel> GetCourseByCourseNrAsync(int courseNr)
        {
            throw new NotImplementedException();
        }

        public Task<CourseViewModel> GetCourseByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CourseViewModel>> ListAllCoursesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCourseAsync(int id, PostCourseViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}