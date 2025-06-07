using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public interface IHomePageSidebar
    {
        List<HomePageSidebar> GetAllHomePageSidebar();
        HomePageSidebar GetHomePageSidebarById(int Id);
        bool AddHomePageSidebar(HomePageSidebar homePageSidebar);
        bool UpdateHomePageSidebar(HomePageSidebar homePageSidebar);
        bool DeleteHomePageSidebar(int Id);
        List<HomePageSidebar> GetAllHomeSidebarByTechId(int Id);

    }
}
