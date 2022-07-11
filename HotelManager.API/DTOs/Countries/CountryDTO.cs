using HotelManager.API.DTOs.Hotels;

namespace HotelManager.API.DTOs.Countries
{
    public class CountryDTO : BaseCountryDTO
    {
        public int Id { get; set; }
     
        public List<HotelDTO> Hotels { get; set; }
    }
}
