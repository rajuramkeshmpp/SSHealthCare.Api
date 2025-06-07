using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHealthCare.Infrastructure.Repository
{
    public class HomePageSidebarRepository : IHomePageSidebar
    {
        private readonly ApplicationDbContext _context;
        public HomePageSidebarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddHomePageSidebar(HomePageSidebar homePageSidebar)
        {
            _context.HomePageSidebars.Add(homePageSidebar);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHomePageSidebar(int Id)
        {
            var d = _context.HomePageSidebars.Find(Id);
            _context.HomePageSidebars.Remove(d);
            _context.SaveChanges();
            return true;
        }

        public List<HomePageSidebar> GetAllHomePageSidebar()
        {
            return _context.HomePageSidebars.ToList();
        }

        public List<HomePageSidebar> GetAllHomeSidebarByTechId(int Id)
        {
            return _context.HomePageSidebars.Where(x=>x.TechnologyId == Id).ToList();
        }

        public HomePageSidebar GetHomePageSidebarById(int Id)
        {
            return _context.HomePageSidebars.Find(Id);
        }

        public bool UpdateHomePageSidebar(HomePageSidebar homePageSidebar)
        {
            _context.HomePageSidebars.Update(homePageSidebar);
            _context.SaveChanges();
            return true;
        }
    }
}
