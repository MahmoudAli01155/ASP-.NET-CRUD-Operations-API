﻿namespace WebApplicationAPI.DTO
{
    public class UsergetDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
