using AutoMapper;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Model;

namespace WebApplicationAPI.Automapper
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, CreateBrandDTO>().ReverseMap();
            CreateMap<Brand, UpdateBrandDTO>().ReverseMap();
            CreateMap<Brand, BrandgetDTO>().ReverseMap();
        }


    }
}
