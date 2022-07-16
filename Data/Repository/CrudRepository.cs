using GPACalculator.Models;

namespace GPACalculator.Data.Repository
{
    public abstract class CrudRepository
    {
        public virtual void Add(User user) { }
        public virtual User GetSingle(string id)
        {
            return null;
        }
        public virtual List<User> GetAll() 
        {
            return null;
        }
        public virtual void Update(string id, User updateUser) { }
        public virtual void Delete(string id) { }
    }
}
