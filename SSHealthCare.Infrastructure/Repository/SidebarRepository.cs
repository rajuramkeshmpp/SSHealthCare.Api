

using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Infrastructure.Repository
{
    public class SidebarRepository : ISidebar
    {
        private readonly ApplicationDbContext _context;
        public SidebarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Sidebar> GetAll()
        {
            return _context.Sidebars.ToList();
        }

        public Sidebar GetSidebarById(int Id)
        {
            return _context.Sidebars.Find(Id);
        }

        public List<Sidebar> GetSidebbarByRoleId(int RoleId)
        {
            return _context.Sidebars.Where(x=>x.RoleId == RoleId).ToList();
        }
    }
}
