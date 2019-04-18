using Fourth_Task.DAL.Models;

namespace Fourth_Task.DAL
{
    public interface IUserRepository : IRepository<User>
    {
        void Update(long id, User user);
    }
}
