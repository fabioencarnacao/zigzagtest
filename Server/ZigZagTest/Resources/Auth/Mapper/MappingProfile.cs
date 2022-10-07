using AutoMapper;
using ZigZagTest.Data.Entities;
using ZigZagTest.WebAPI.Resources.Auth.Models;

namespace ZigZagTest.WebAPI.Resources.Auth.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email));
        }
    }
}
