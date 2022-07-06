using System.ComponentModel.DataAnnotations;

namespace HotelManager.API.DTOs.Countries
{
    public class CreateCountryDTO
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
