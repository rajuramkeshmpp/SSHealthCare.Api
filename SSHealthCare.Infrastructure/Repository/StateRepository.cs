using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;
using System.Diagnostics.Metrics;


namespace SSHealthCare.Infrastructure.Repository
{
    public class StateRepository : IState
    {
        private readonly ApplicationDbContext _context;
        public StateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddState(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteState(int Id)
        {
            var d = _context.States.Find(Id);
            _context.States.Remove(d);
            _context.SaveChanges();
            return true;
        }

        public List<State> GetAllState()
        {
            return _context.States.ToList();
        }

        public State GetStateById(int Id)
        {
            return _context.States.Find(Id);
        }

        public bool UpdateState(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
            return true;
        }
    }
}
