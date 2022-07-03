using HotelManager.API.Models.Hotels;
using Microsoft.EntityFrameworkCore;

namespace HotelManager.API.Seeder.Hotels
{
    public static class HotelData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Department
            modelBuilder.Entity<Hotel>()
                .HasData(
                           new Hotel
                           {
                               Id = 1,
                               Name = "Kenya One",
                               Address = "Western Kenya",
                               CountryId = 1,
                               Rating = 5
                           },
                           new Hotel
                           {
                               Id = 2,
                               Name = "Uganda One",
                               Address = "Western UG",
                               CountryId = 2,
                               Rating = 5
                           },
                            new Hotel
                            {
                                Id = 3,
                                Name = "TZ One",
                                Address = "Western TZ",
                                CountryId = 3,
                                Rating = 5
                            }, new Hotel
                            {
                                Id = 4,
                                Name = "Kenya Two",
                                Address = "Nairobi Kenya",
                                CountryId = 1,
                                Rating = 5
                            }
                            , new Hotel
                            {
                                Id = 4,
                                Name = "Kenya Two",
                                Address = "Nairobi Kenya",
                                CountryId = 1,
                                Rating = 5
                            }
                            , new Hotel
                            {
                                Id = 5,
                                Name = "Kenya Two",
                                Address = "Nairobi Kenya",
                                CountryId = 2,
                                Rating = 5
                            }
                            , new Hotel
                            {
                                Id = 6,
                                Name = "Kenya Two",
                                Address = "Nairobi Kenya",
                                CountryId = 3,
                                Rating = 5
                            }
            );
        }
    }
}
