using HotelManager.API.Models.Countries;
using Microsoft.EntityFrameworkCore;

namespace HotelManager.API.Seeder.Countries
{
    public static class CountryData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                       .HasData(
                         new Country
                         {
                             Id = 1,
                             Name = "Kenya",
                             ShortName = "KE"
                         },
                         new Country
                         {
                             Id = 2,
                             Name = "Uganda",
                             ShortName = "UG"
                         },
                         new Country
                         {
                             Id = 3,
                             Name = "Tanzania",
                             ShortName = "TZ"
                         },
                         new Country
                         {
                             Id = 4,
                             Name = "Rwanda",
                             ShortName = "TZ"
                         }
                         ,
                         new Country
                         {
                             Id = 5,
                             Name = "Burundi",
                             ShortName = "TZ"
                         },
                         new Country
                         {
                             Id = 6,
                             Name = "Nigeria",
                             ShortName = "NG"
                         },
                         new Country
                         {
                             Id = 7,
                             Name = "Chad",
                             ShortName = "CD"
                         }
                       );

        }
    }
}
