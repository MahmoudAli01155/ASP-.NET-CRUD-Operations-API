using WebApplicationAPI.DTO;

namespace WebApplicationAPI.Repository.Brand
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandgetDTO>> getAllBrandes();

        Task<BrandgetDTO> GetById(int id);

        Task<BrandgetDTO> create(CreateBrandDTO CreateBrandDTO);
        Task<BrandgetDTO> update(UpdateBrandDTO UpdateBrandDTO);
        Task delete(int id);
        
    }
}
