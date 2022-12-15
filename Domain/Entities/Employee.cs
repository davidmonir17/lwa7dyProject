using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "name is required field")]
        [MaxLength(60, ErrorMessage = "name Field not Exceded 60 char")]
        public string Name { get; set; }

        [Required(ErrorMessage = "NationalId is required field")]
        [MaxLength(14, ErrorMessage = "NationalId Field not Exceded 14 char")]
        public int NationalId { get; set; }

        public String Address { get; set; }

        [ForeignKey(nameof(depertment))]
        [Required]
        public int DepId { get; set; }

        public Depertment depertment { get; set; }
    }
}