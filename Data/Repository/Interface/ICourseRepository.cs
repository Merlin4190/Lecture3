using GPACalculator.Models;

namespace GPACalculator.Data.Repository.Interface
{
    public interface ICourseRepository
    {
        public void Add(Course course);
        public Course GetSingle(string courseId);
        public List<Course> GetAll();
        public void Update(string courseId, Course updatedCourse);
        public void Delete(string courseId);
    }
}
