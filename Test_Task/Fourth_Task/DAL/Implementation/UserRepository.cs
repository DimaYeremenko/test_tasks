using Fourth_Task.DAL.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Fourth_Task.DAL.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _dataStorage;

        public UserRepository()
        {
            using (var streamReader = new StreamReader("InitialState.json"))
            {
                var json = streamReader.ReadToEnd();
                _dataStorage = JsonConvert.DeserializeObject<List<User>>(json);
            }

            if (_dataStorage == null || !_dataStorage.Any())
            {
                _dataStorage = new List<User>()
                {
                    new User()
                    {
                        Id = 1,
                        Name = "Taras",
                        LastName = "Mobich",
                    },
                    new User()
                    {
                        Id = 2,
                        Name = "Petro",
                        LastName = "Mobich",
                    },
                    new User()
                    {
                        Id = 3,
                        Name = "Ivan",
                        LastName = "Task",
                    },
                    new User()
                    {
                        Id = 4,
                        Name = "Dima",
                        LastName = "Test",
                    },
                    new User()
                    {
                        Id = 5,
                        Name = "Igor",
                        LastName = "Reset",
                    },
                };

                Save();
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _dataStorage;
        }

        public void Update(long id, User user)
        {
            if (_dataStorage.RemoveAll(u => u.Id == id) > 0)
            {
                _dataStorage.Add(user);
            }

            Save();
        }

        private void Save()
        {
            var data = JsonConvert.SerializeObject(_dataStorage);
            using (var streamWriter = new StreamWriter("InitialState.json"))
            {
                streamWriter.Write(data);
            }
        }
    }
}
