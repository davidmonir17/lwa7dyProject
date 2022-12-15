using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataTransferObject
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int NationalId { get; set; }
        public String Address { get; set; }

        public int DepId { get; set; }
    }
}