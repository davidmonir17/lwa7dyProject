using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.configrations
{
    public class EmployeeConfigration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Name = "david",
                    NationalId = 01111111,
                    Address = "El zaher cairo",
                    DepId = 1
                },
                new Employee
                {
                    Id = 2,
                    Name = "ahmed",
                    NationalId = 01111551,
                    Address = "El zaher cairo",
                    DepId = 2
                }
                );
        }
    }
}