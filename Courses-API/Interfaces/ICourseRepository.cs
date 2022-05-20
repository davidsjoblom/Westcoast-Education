using Courses_API.ViewModels.Course;

namespace Courses_API.Interfaces
{
    public interface ICourseRepository
    {
        public Task<List<CourseViewModel>> ListAllCoursesAsync();
        public Task<CourseViewModel> GetCourseByIdAsync(int id);
        public Task<CourseViewModel> GetCourseByCourseNrAsync(int courseNr);
        public Task AddCourseAsync(PostCourseViewModel model);
        public Task DeleteCourseAsync(int id);
        public Task UpdateCourseAsync(int id, PostCourseViewModel model);
        public Task<bool> SaveAllAsync();
    }
}