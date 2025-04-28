﻿using System.ComponentModel.DataAnnotations;

namespace HotelsListing.API.Models.Hotels;

public abstract class BaseHotelDto
{
    public string Name { get; set; }
    
    [Required]
    public string Address { get; set; }

    public double? Rating { get; set; }

    [Required]
    [Range(1,int.MaxValue)]
    public int CountryId { get; set; }
}