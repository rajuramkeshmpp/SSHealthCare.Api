

using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public interface ITechnology
    {
        List<Technology> GetAllTechnology();
        Technology GetTechnologyById(int Id);
        bool AddTechnology(Technology technology);
        bool UpdateTechnologyy(Technology technology);
        bool DeleteTechnology(int Id);
    }
}
