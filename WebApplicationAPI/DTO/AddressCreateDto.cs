namespace WebApplicationAPI.DTO
{
    public class AddressCreateDto
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        // Optional: Include UserId if needed for explicit assignment
        public int? UserId { get; set; }
    }
}
