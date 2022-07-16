using GPACalculator.Data.Repository.Interface;
using GPACalculator.Models;

namespace GPACalculator.Data.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
       
        #region interface implementation
        private readonly DbContext _context;

        public UserRepository(DbContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
        }

        public void Delete(string userId)
        {
            var user = GetSingle(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
            }
            else throw new Exception($"Course with this {userId} was not found");
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetSingle(string userId)
        {
            return _context.Users.FirstOrDefault(x => x.Id == userId) ?? throw new Exception($"Course with this {userId} was not found");
        }

        public void Update(string userId, User updatedUser)
        {
            var user = GetSingle(userId);
            if (user != null)
            {
                user.FirstName = updatedUser.FirstName;
                user.LastName = updatedUser.LastName;
                user.Department = updatedUser.Department;
                user.Level = updatedUser.Level;
                user.DateUpdated = DateTime.Now;
            }
            else throw new Exception($"Course with this {userId} was not found");
        }
        #endregion
    }
}
