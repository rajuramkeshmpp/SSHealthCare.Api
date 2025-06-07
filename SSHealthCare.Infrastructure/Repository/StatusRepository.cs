using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;


namespace SSHealthCare.Infrastructure.Repository
{
    public class StatusRepository : IStatus
    {
        private readonly ApplicationDbContext _context;
        public StatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Status> GetAllStatus()
        {
            return _context.Statuses.ToList();
        }
    }
}
