﻿

using System.ComponentModel.DataAnnotations;

namespace SSHealthCare.Domain.Entities
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
