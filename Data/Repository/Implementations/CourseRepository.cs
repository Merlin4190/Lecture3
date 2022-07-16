using GPACalculator.Data.Repository.Interface;
using GPACalculator.Models;

namespace GPACalculator.Data.Repository.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DbContext _context;

        public CourseRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
        }

        public void Delete(string courseId)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == courseId);
            if (course != null) _context.Courses.Remove(course);
            else throw new Exception($"Course with this {courseId} was not found");
        }

        public List<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course GetSingle(string courseId)
        {
            return _context.Courses.FirstOrDefault(c => c.Id == courseId) ?? throw new Exception($"Course with this {courseId} was not found");
        }

        public void Update(string courseId, Course updatedCourse)
        {
            var course = GetSingle(courseId);
            if (course != null)
            {
                course.CourseName = updatedCourse.CourseName;
                course.CourseUnit = updatedCourse.CourseUnit;
                course.DateUpdated = DateTime.Now;
            }
            else throw new Exception($"Course with this {courseId} was not found");
        }
    }
}
