

using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public interface IUser
    {
        bool AddUser(User user);
        List<User> GetAllUser();
    }
}
