

using SSHealthCare.Domain.Entities;

namespace SSHealthCare.Domain.Interfaces
{
    public interface ITaskManager
    {
        List<TaskManager> GetAllTask();
        Task GetTaskById(int Id);
        bool AddTask(Task task);
        bool UpdateTask(Task task);
        bool DeleteTask(int Id);
    }
}
