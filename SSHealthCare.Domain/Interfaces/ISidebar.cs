

using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public  interface ISidebar
    {
        List<Sidebar> GetAll();
        Sidebar GetSidebarById(int Id);
        List<Sidebar> GetSidebbarByRoleId(int RoleId);
    }
}
