using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Depertment
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}