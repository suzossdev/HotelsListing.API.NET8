using HotelsListing.API.Models.Hotels;

namespace HotelsListing.API.Models.Country;
    public class CountryDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
