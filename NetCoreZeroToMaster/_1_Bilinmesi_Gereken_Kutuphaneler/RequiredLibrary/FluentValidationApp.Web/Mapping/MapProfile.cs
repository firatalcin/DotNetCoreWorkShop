using AutoMapper;
using FluentValidationApp.Web.DTOs;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}