namespace GPACalculator.Models
{
    public abstract class BaseIdentity
    {
        public string Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }

        public BaseIdentity()
        {
            Id = new Guid().ToString();
            DateCreated = DateTime.Now;
        }
    }
}
