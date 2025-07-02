namespace WebApplicationAPI.Repository.User
{
    public interface IUserRepository : IRepository<Model.User>
    {
        Task<Model.User> GetUserWithAddressesAsync(int userId);
        Task<Model.User> AddUserWithAddressesAsync(Model.User user);
    }
}
