
using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public  interface IState
    {
        List<State> GetAllState();
        State GetStateById(int Id);
        bool AddState(State state);
        bool DeleteState(int Id);
        bool UpdateState(State state);
    }
}
