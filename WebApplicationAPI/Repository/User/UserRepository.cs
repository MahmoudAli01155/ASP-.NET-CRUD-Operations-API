using Microsoft.EntityFrameworkCore;
using WebApplicationAPI.Data;

namespace WebApplicationAPI.Repository.User
{
    public class UserRepository : Repository<Model.User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Model.User> AddUserWithAddressesAsync(Model.User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<Model.User> GetUserWithAddressesAsync(int userId)
        {
            return await _context.Users
                    .Include(u => u.Addresses)
                    .FirstOrDefaultAsync(u => u.Id == userId);
        }
    }
}
