
using SSHealthCare.Domain.Entities;


namespace SSHealthCare.Domain.Interfaces
{
    public interface IRole
    {
        List<Role> GetAllRole();
        Role GetRoleById(int Id);
        bool AddRole(Role role);
        bool UpdateRole(Role role);
        bool DeleteRole(int Id);
    }
}
