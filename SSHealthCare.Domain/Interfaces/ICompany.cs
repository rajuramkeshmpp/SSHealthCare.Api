using SSHealthCare.Domain.Entities;


namespace SSHealthCare.Domain.Interfaces
{
    public interface ICompany
    {
        List<Company> GetAllCompany();
        Company GetComapnyById(int Id);
        bool AddComapany(Company company);
        bool UpdateCompany(Company company);
        bool DeleteCompany(int Id);
    }
}
