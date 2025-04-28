using AutoMapper;
using HotelsListing.API.Data;
using HotelsListing.API.Models.Country;
using HotelsListing.API.Models.Hotels;

namespace HotelsListing.API.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<Country, CreateCountryDTO>().ReverseMap();
        CreateMap<Country, GetCountryDTO>().ReverseMap();
        CreateMap<Country, CountryDTO>().ReverseMap();
        CreateMap<Country, UpdateCountryDTO>().ReverseMap();

        CreateMap<Hotel, HotelDto>().ReverseMap();
    }
}

