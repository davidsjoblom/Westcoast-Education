using Courses_API.Interfaces;
using Courses_API.ViewModels.Subject;

namespace Courses_API.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        public Task AddSubjectAsync(PostSubjectViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSubjectAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SubjectViewModel?> GetSubjectByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SubjectViewModel>> ListAllSubjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateSubjectAsync(int id, PostSubjectViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}