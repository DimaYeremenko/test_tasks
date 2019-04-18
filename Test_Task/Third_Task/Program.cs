using System;
using System.Collections.Generic;
using Third_Task.Models;
using Third_Task.Repository;
using Third_Task.Service;
using Third_Task.View;

namespace Third_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseContext();
            var repository = new UserRepository(context);
            var service = new UserService(repository);
            var controller = new UserController(service);

            var initData = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Name = "John",
                    LastName = "John1",
                },
                new User()
                {
                    Id = 2,
                    Name = "Taras",
                    LastName = "Taras2",
                },
                new User()
                {
                    Id = 3,
                    Name = "Tim",
                    LastName = "Tim3",
                },
            };

            Console.WriteLine("Test creation users");
            Test(controller, initData);


            Console.ReadKey();
        }

        private static void Test(UserController controller, List<User> users)
        {
            // create
            foreach (var user in users)
            {
                controller.Create(user);
            }

            foreach (var user in users)
            {
                var dbUser = controller.Get(user.Id);
                if (dbUser.Name.Equals(user.Name))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"User {user.Name} is contain in DB.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"User {user.Name} isn't contain in DB.");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
