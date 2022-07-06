using AutoMapper;
using AutoMapperApp.API.DTOs;
using AutoMapperApp.API.Models;

namespace AutoMapperApp.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            //CreateMap<Customer, CustomerDto>().ReverseMap();

            CreateMap<CreditCard, CustomerDto>();

            CreateMap<Customer, CustomerDto>()
                .IncludeMembers(x => x.CreditCard)
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age)).ReverseMap();
        }
    }
}