

using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;

namespace SSHealthCare.Infrastructure.Repository
{
    public class UserRepository : IUser
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context )
        {
            _context = context;
        }

        public bool AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return true;
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }
    }
}
