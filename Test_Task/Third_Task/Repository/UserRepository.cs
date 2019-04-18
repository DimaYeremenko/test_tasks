using System;
using System.Collections.Generic;
using System.Linq;
using Third_Task.Models;

namespace Third_Task.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _context;

        public UserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Create(User entity)
        {
            _context.Users.Add(entity);
        }

        public void Update(User entity, long id)
        {
            if (_context.Users.RemoveAll(u => u.Id == id) > 0)
            {
                _context.Users.Add(entity);
            }
        }

        public void Delete(long id)
        {
            var user = Get(id);
            if (user == null)
            {
                throw new NullReferenceException($"User with id {id} doesn't exist in db");
            }

            _context.Users.Remove(user);
        }

        public User Get(long id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
