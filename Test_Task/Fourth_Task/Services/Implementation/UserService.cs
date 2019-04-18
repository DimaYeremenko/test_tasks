using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Fourth_Task.DAL;
using Fourth_Task.Services.Models;

namespace Fourth_Task.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public IEnumerable<User> GetAll()
        {
            var users = _userRepository.GetAll();
            return _mapper.Map<List<User>>(users);
        }

        public IEnumerable<User> GetByName(string name)
        {
            var users = _mapper.Map<List<User>>(_userRepository.GetAll());
            return users.Where(u => u.Name.StartsWith(name, StringComparison.InvariantCultureIgnoreCase));
        }

        public void Update(long id, User user)
        {
            _userRepository.Update(id, _mapper.Map<DAL.Models.User>(user));
        }
    }
}
