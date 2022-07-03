using HotelManager.API.Models.Countries;
using HotelManager.API.Models.Hotels;

//using HotelManager.API.Seeder.Countries;


using Microsoft.EntityFrameworkCore;

namespace HotelManager.API.Models
{
    public class HotelManagerDbContext: DbContext
    {
        public HotelManagerDbContext(DbContextOptions<HotelManagerDbContext> options): base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Countries
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
                             Id=2,
                             Name="Uganda",
                             ShortName="UG"
                         },
                         new Country
                         {
                             Id=3,
                             Name="Tanzania",
                             ShortName="TZ"
                         }
                       );
           // modelBuilder.Entity<Country>().HasKey(e => new { e.ShortName, e.Name, e.Id });
           // modelBuilder.Entity<Hotel>().HasKey(e => new { e.Id,e.Name,e.Address,e.Rating,e.CountryId });
             modelBuilder.Entity<Hotel>()
                         .HasData(
                           new Hotel
                           {
                               Id = 1,
                               Name = "Kenya One",
                               Address="Western Kenya",
                               CountryId=1,
                               Rating=5  
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
                  );
                             



           
          
        }
    }
}
