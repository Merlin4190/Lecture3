using GPACalculator.Models;

namespace GPACalculator.Data
{
    public class DbContext
    {
        public List<User> Users { get; set; }
        public List<Course> Courses { get; set; }
        public List<UserCourse> UserCourses { get; set; }

        public DbContext()
        {
            Users = new List<User>();
            Courses = new List<Course>();
            UserCourses = new List<UserCourse>();
        }
    }
}