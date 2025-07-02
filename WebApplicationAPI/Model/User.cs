﻿namespace WebApplicationAPI.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
        public bool IsActive { get; set; } = true;
        // Navigation property (one-to-many)
        public ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}
