using System.ComponentModel.DataAnnotations.Schema;

namespace HotelsListing.API.Models.Hotels;
public class HotelDto : BaseHotelDto
{
    public int Id { get; set; }

}