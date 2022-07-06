using AutoMapper;
using HotelManager.API.DTOs.Countries;
using HotelManager.API.Models.Countries;

namespace HotelManager.API.Profiles
{
    public class ProfileMapper :Profile
    {
        public ProfileMapper()
        {
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, GetCountryDTO>().ReverseMap();
        }
    }
}
