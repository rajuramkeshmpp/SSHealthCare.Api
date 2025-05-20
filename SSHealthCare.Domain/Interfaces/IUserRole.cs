

using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public interface IUserRole
    {
        List<UserRole> GetAllUserRole();
        UserRole GetUserRoleById(int Id);
    }
}
