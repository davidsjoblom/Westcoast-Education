using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Courses_API.Data;
using Courses_API.Interfaces;
using Courses_API.Models;
using Courses_API.ViewModels.Course;
using AutoMapper.QueryableExtensions;

namespace Courses_API.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public CourseRepository(ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task AddCourseAsync(PostCourseViewModel model)
        {
            //Kolla att ämnet finns
            var subject = await _context.Subjects
                .Where(s => s.Name!.ToLower() == model.SubjectName!.ToLower())
                .SingleOrDefaultAsync();
            if (subject is null)
            {
                throw new Exception($"Ämnet {model.SubjectName} hittades inte i systemet");
            }

            //Kolla att läraren finns
            var teacher = await _context.Teachers
                .Where(t => string.Concat(t.FirstName, " ", t.LastName).ToLower() == model.TeacherName!.ToLower().Trim())
                .SingleOrDefaultAsync();
            if (teacher is null)
            {
                throw new Exception($"Läraren {model.TeacherName} hittades inte i systemet");
            }

            var course = _mapper.Map<Course>(model);
            course.Subject = subject;
            course.Teacher = teacher;

            await _context.Courses.AddAsync(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course is null)
            {
                throw new Exception($"Ingen kurs med id: {id} hittades");
            }
            _context.Courses.Remove(course);
        }

        public async Task<CourseViewModel?> GetCourseByCourseNrAsync(int courseNr)
        {
            return await _context.Courses
                .Where(c => c.CourseNr == courseNr)
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<CourseViewModel?> GetCourseByIdAsync(int id)
        {
            return await _context.Courses
                .Where(c => c.Id == id)
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        public async Task<List<CourseViewModel>> ListAllCoursesAsync()
        {
            return await _context.Courses
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task UpdateCourseAsync(int id, PostCourseViewModel model)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course is null) 
            {
                throw new Exception($"Ingen kurs med id: {id} hittades");
            }

            var subject = await _context.Subjects
                .Where(s => s.Name!.ToLower() == model.SubjectName!.ToLower())
                .SingleOrDefaultAsync();
            if (subject is null)
            {
                throw new Exception($"Ämnet {model.SubjectName} hittades inte i systemet");
            }

            var teacher = await _context.Teachers
                .Where(t => string.Concat(t.FirstName, " ", t.LastName).ToLower() == model.TeacherName!.ToLower().Trim())
                .SingleOrDefaultAsync();
            if (teacher is null)
            {
                throw new Exception($"Läraren {model.TeacherName} hittades inte i systemet");
            }

            course.CourseNr = model.CourseNr;
            course.Description = model.Description;
            course.Details = model.Details;
            course.Duration = model.Duration;
            course.Title = model.Title;
            //course.SubjectId = subject.Id; borde fixa det själv?
            course.Subject = subject;
            //course.TeacherId = teacher.Id; borde fixa det själv?
            course.Teacher = teacher;

            _context.Courses.Update(course);
        }
    }
}