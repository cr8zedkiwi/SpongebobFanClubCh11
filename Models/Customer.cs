using System.ComponentModel.DataAnnotations;

namespace SongebobFanClub.Models
{
    public class Customer
    {
        [Display(Name ="Customer ID")]
        public int CustomerId { get; set; }
        public string? Name { get; set; }

        public int CustomerCityId { get; set; }
        public CustomerCity? City {  get; set; }
    }
}
