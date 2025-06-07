
using System.ComponentModel.DataAnnotations;
namespace SSHealthCare.Domain.Entities
{
    public class TaskManager
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; }

    }
}
