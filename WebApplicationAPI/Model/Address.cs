namespace WebApplicationAPI.Model
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        // Foreign key
        public int UserId { get; set; }

        // Navigation property (many-to-one)
        public User User { get; set; }
    }
}
