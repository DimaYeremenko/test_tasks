using AutoMapper;
using Fourth_Task.DAL.Models;
using Fourth_Task.Models;

namespace Fourth_Task.DAL.Bootstrapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, Services.Models.User>();

            CreateMap<Services.Models.User, UserViewModel>();
            CreateMap<UserViewModel, Services.Models.User>();
        }
    }
}
