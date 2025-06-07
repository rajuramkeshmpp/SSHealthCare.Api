using SSHealthCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHealthCare.Domain.Interfaces
{
    public  interface IStatus
    {
        List<Status> GetAllStatus();
    }
}
