﻿

using System.ComponentModel.DataAnnotations;

namespace SSHealthCare.Domain.Entities
{
    public  class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
}
