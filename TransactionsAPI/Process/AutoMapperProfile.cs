using AutoMapper;
using TransactionsAPI.DataModels;
using TransactionsAPI.ViewModels;

namespace TransactionsAPI.Process
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap <InputProfileDto, Profiles>().ForMember(dest => dest.name, opt => opt.MapFrom(src => src.UserName)).ForMember(dest => dest.img, opt => opt.MapFrom(src => src.ProfileImg)).ReverseMap();
        }
    }
}
