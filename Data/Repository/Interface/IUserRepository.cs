using GPACalculator.Models;

namespace GPACalculator.Data.Repository.Interface
{
    public interface IUserRepository
    {
        public void Add(User user);
        public User GetSingle(string userId);
        public List<User> GetAll();
        public void Update(string userId, User updatedUser);
        public void Delete(string userId);
    }
}
