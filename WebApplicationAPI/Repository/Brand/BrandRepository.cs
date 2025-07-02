using WebApplicationAPI.Data;

namespace WebApplicationAPI.Repository.Brand
{
    public class BrandRepository : Repository<Model.Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
