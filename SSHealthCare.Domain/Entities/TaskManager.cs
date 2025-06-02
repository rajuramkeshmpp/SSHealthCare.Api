using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHealthCare.Domain.Entities
{
    public class TaskManager
    {
        [Key]
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public int UserId { get; set; }

        public int StatusId { get; set; }

    }
}
