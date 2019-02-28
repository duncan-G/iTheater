using AutoMapper;
using Server.Dtos;
using Server.Models;

namespace Server.Helpers {
    public class AutoMappers : Profile {

        public AutoMappers () {
            CreateMap<User, UserDto> ();
            CreateMap<UserDto, User> ();
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryDto>();
        }
    }
}