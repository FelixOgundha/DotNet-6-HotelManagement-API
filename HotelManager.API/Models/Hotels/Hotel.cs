﻿using HotelManager.API.Models.Countries;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManager.API.Models.Hotels
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }

        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}