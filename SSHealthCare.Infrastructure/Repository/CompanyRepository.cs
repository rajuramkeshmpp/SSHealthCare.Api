

using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;


namespace SSHealthCare.Infrastructure.Repository
{
    public class CompanyRepository : ICompany
    {
        private readonly ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context)
        {
             _context = context;
        }

        public bool AddComapany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCompany(int Id)
        {
            var d = _context.Companies.Find(Id);
            _context.Companies.Remove(d);
            _context.SaveChanges();
            return true;
        }

        public List<Company> GetAllCompany()
        {
            return _context.Companies.ToList();
        }

        public Company GetComapnyById(int Id)
        {
            return _context.Companies.Find(Id);
        }

        public bool UpdateCompany(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
            return true;
        }
    }
}
