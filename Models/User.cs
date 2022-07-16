namespace GPACalculator.Models
{
    public class User : BaseIdentity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public List<Course> Courses { get; set; }
    }
}