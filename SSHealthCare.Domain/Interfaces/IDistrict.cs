

using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public interface IDistrict
    {
        List<District> GetAllDistrict();
        District GetDistrictById(int Id);
        bool AddDistrict(District district);
        bool DeleteDistrict(int Id);
        bool UpdateDistrict(District district);
    }
}
