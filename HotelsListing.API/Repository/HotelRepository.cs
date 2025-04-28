using HotelsListing.API.Contracts;
using HotelsListing.API.Data;

namespace HotelsListing.API.Repository;
public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
{
    private readonly HotelListingDBContext _context;

    public HotelRepository(HotelListingDBContext context) : base(context)
    {
        this._context = context;
    }

    }
