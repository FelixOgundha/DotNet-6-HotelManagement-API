using AutoMapper;
using HotelManager.API.DTOs.Countries;
using HotelManager.API.DTOs.Hotels;
using HotelManager.API.Models.Countries;
using HotelManager.API.Models.Hotels;

namespace HotelManager.API.Profiles
{
    public class ProfileMapper :Profile
    {
        public ProfileMapper()
        {
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, GetCountryDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();
            CreateMap<Hotel, GetHotelsDTO>().ReverseMap();
            CreateMap<Hotel, HotelDTO>().ReverseMap();

        }
    }
}
