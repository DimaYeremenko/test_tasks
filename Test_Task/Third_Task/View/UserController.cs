using Third_Task.Models;
using Third_Task.Service;

namespace Third_Task.View
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public void Create(User user)
        {
            _userService.Create(user);
        }

        public User Get(long id)
        {
            return _userService.Get(id);
        }
    }
}
