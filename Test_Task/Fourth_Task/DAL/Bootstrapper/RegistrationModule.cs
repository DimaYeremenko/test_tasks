using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Fourth_Task.DAL.Implementation;
using Fourth_Task.Services;
using Fourth_Task.Services.Implementation;

namespace Fourth_Task.DAL.Bootstrapper
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegisterRepositories(builder);
            RegisterServices(builder);
        }

        private void RegisterRepositories(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();
        }

        private void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();
        }
    }
}
