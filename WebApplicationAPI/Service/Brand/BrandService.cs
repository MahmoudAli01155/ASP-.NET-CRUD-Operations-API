

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Model;

namespace WebApplicationAPI.Repository.Brand
{
    public class BrandService : IBrandService
    {
        public IMapper _mapper { get; set; }
        public IBrandRepository Repository { get; set; }



        public BrandService(IBrandRepository BrandRepositry, IMapper mapper) 
        {
            Repository = BrandRepositry;
            _mapper = mapper;

        }



        public async  Task<BrandgetDTO> create(CreateBrandDTO CreateBrandDTO)
        {
            var brand = _mapper.Map<Model.Brand>(CreateBrandDTO);
            var addedbrand = await Repository.AddAsync(brand);
            //await Repository.SaveChangesAsync();
            var response = _mapper.Map<BrandgetDTO>(addedbrand);

            return response;
        }






        public async Task delete(int id)
        {
            var reselt =  Repository.DeleteAsync(id);
            //return reselt;
        }





        public async Task<IEnumerable<BrandgetDTO>> getAllBrandes()
        {
            var brands = await Repository.GetAllAsync();
            //await Repository.SaveChangesAsync();
            var response = _mapper.Map<List<BrandgetDTO>>(brands);
            return response;
            //return Repository.GetAllAsync();
        }






        public async Task<BrandgetDTO> GetById(int id)
        {
            var brands = await Repository.GetByIdAsync(id);
            var response =_mapper.Map<BrandgetDTO>(brands);
            return response;
        }


        






        public async Task<BrandgetDTO> update(UpdateBrandDTO UpdateBrandDTO)
        {
            var brand = _mapper.Map<Model.Brand>(UpdateBrandDTO);
            var updateBrand = await Repository.UpdateAsync(brand);
            var response = _mapper.Map<BrandgetDTO>(updateBrand);
            return response;
        }



    }
}
