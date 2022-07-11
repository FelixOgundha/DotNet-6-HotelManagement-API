using System.ComponentModel.DataAnnotations;

namespace HotelManager.API.DTOs.Countries
{
    public abstract class BaseCountryDTO
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
