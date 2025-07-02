using AutoMapper;
using WebApplicationAPI.DTO;
using WebApplicationAPI.Repository.User;

namespace WebApplicationAPI.Service.User
{
    public class UserService : IUserService
    {
        public IMapper _mapper { get; set; }
        public IUserRepository Repository { get; set; }



        public UserService(IUserRepository UserRepositry, IMapper mapper)
        {
            Repository = UserRepositry;
            _mapper = mapper;

        }

        public async Task<IEnumerable<UsergetDTO>> getAll()
        {
            var users = await Repository.GetAllAsync();
            var response = _mapper.Map<List<UsergetDTO>>(users);
            return response;
        }

        public async Task<UsergetDTO> GetById(int id)
        {
            var user = await Repository.GetByIdAsync(id);
            var response = _mapper.Map<UsergetDTO>(user);
            return response;
        }

        public async Task<UsergetDTO> create(CreateUserDTO CreateUserDTO)
        {
            var user = _mapper.Map<Model.User>(CreateUserDTO);
            var addeduser = await Repository.AddAsync(user);
            var response = _mapper.Map<UsergetDTO>(addeduser);

            return response;
        }

        public async Task<UsergetDTO> update(UpdateUserDTO UpdateUserDTO)
        {
            var brand = _mapper.Map<Model.User>(UpdateUserDTO);
            var updateBrand = await Repository.UpdateAsync(brand);
            var response = _mapper.Map<UsergetDTO>(updateBrand);
            return response;
        }

        public async Task delete(int id)
        {
             await Repository.DeleteAsync(id);
        }




        public async Task<UserDto> CreateUserWithAddressesAsync(UserCreateDto userDto)
        {
            var user = _mapper.Map<Model.User>(userDto);
             await Repository.AddUserWithAddressesAsync(user);
            var userMap = _mapper.Map<UserDto>(user);
            return userMap;
        }

        public async Task<UserDto> GetUserWithAddressesAsync(int id)
        {
            var user = await Repository.GetUserWithAddressesAsync(id);
            return _mapper.Map<UserDto>(user);
        }
    }
}
