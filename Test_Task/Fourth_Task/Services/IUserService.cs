using Fourth_Task.Services.Models;
using System.Collections.Generic;

namespace Fourth_Task.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();

        IEnumerable<User> GetByName(string name);

        void Update(long id, User user);
    }
}
