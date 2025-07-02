﻿namespace WebApplicationAPI.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<AddressDto> Addresses { get; set; } = new List<AddressDto>();
    }
}
