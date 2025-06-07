using SSHealthCare.Domain.Entities;
using SSHealthCare.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHealthCare.Infrastructure.Repository
{
    public class TaskManagerRepository : ITaskManager
    {
        private readonly ApplicationDbContext _context;
        public TaskManagerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddTask(Task task)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTask(int Id)
        {
            throw new NotImplementedException();
        }

        public List<TaskManager> GetAllTask()
        {
            throw new NotImplementedException();
        }

        public Task GetTaskById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTask(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
