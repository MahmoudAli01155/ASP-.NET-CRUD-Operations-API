namespace WebApplicationAPI.Model
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> products { get; set; }
    }
}
