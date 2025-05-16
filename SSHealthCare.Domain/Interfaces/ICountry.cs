using SSHealthCare.Domain.Entities;


namespace SSHealthCare.Domain.Interfaces
{
    public interface ICountry
    {
        List<Country> GetAllCountry();
        Country GetCountryById(int Id);
        bool AddCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(int Id);
    }
}
