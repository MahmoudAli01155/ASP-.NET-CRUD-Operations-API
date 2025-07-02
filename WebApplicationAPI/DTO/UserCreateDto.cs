namespace WebApplicationAPI.DTO
{
    public class UserCreateDto
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;
        //[ValidateComplexType]
        public List<AddressCreateDto> Addresses { get; set; } = new List<AddressCreateDto>();
    }
}
