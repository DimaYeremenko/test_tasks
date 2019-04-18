using System.Collections.Generic;
using Third_Task.Models;

namespace Third_Task.Repository
{
    public class DatabaseContext
    {
        public List<User> Users { get; set; }

        public DatabaseContext()
        {
            Users = new List<User>();
        }
    }
}
