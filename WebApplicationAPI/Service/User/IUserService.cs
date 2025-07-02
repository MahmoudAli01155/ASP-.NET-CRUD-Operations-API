using WebApplicationAPI.DTO;

namespace WebApplicationAPI.Service.User
{
    public interface IUserService
    {
        Task<IEnumerable<UsergetDTO>> getAll();

        Task<UsergetDTO> GetById(int id);

        Task<UsergetDTO> create(CreateUserDTO CreateUserDTO);
        Task<UsergetDTO> update(UpdateUserDTO UpdateUserDTO);
        Task delete(int id);
        Task<UserDto> CreateUserWithAddressesAsync(UserCreateDto userDto);
        Task<UserDto> GetUserWithAddressesAsync(int id);
    }
}
