using System;
using System.Collections.Generic;
using Third_Task.Models;
using Third_Task.Repository;

namespace Third_Task.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Create(User entity)
        {
            _repository.Create(entity);
        }

        public void Update(User entity, long id)
        {
            _repository.Update(entity, id);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public User Get(long id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
