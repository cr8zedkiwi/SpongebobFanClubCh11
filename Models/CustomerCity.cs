namespace SongebobFanClub.Models
{
    public class CustomerCity
    {
        public int CustomerCityId { get; set; }

        public string? City { get; set; }

        public ICollection<Customer> Customer { get; set; } = default!;
    }
}
