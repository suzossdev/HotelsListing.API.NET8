using HotelsListing.API.Data;

namespace HotelsListing.API.Contracts;

public interface ICountriesRepository : IGenericRepository<Country>
{
    Task<Country> GetDetails(int id);
}
