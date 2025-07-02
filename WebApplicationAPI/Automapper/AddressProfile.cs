using AutoMapper;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Model;

namespace WebApplicationAPI.Automapper
{
    public class AddressProfile : Profile
    {
        public AddressProfile() 
        {
            CreateMap<Address, AddressCreateDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}
