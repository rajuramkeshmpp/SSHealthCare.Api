

using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;
using System.Diagnostics.Metrics;

namespace SSHealthCare.Infrastructure.Repository
{

    public class TechnologyRepository : ITechnology
    {
        private readonly ApplicationDbContext _context;
        public TechnologyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddTechnology(Technology technology)
        {
            _context.Technologies.Add(technology);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteTechnology(int Id)
        {
            var d = _context.Technologies.Find(Id);
            _context.Technologies.Remove(d);
            _context.SaveChanges();
            return true;
        }

        public List<Technology> GetAllTechnology()
        {
            return _context.Technologies.ToList();
        }

        public Technology GetTechnologyById(int Id)
        {
            return _context.Technologies.Find(Id);
        }

        public bool UpdateTechnologyy(Technology technology)
        {
            _context.Technologies.Update(technology);
            _context.SaveChanges();
            return true;
        }
    }
}
