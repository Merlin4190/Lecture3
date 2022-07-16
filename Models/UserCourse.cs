using System.ComponentModel.DataAnnotations.Schema;

namespace GPACalculator.Models
{
    public class UserCourse : BaseIdentity
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int CourseScore { get; set; }
    }
}
