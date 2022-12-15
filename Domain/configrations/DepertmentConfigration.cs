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
    public class DepertmentConfigration : IEntityTypeConfiguration<Depertment>
    {
        public void Configure(EntityTypeBuilder<Depertment> builder)
        {
            builder.HasData(
                new Depertment
                {
                    Id = 1,
                    Name = "IT"
                },
                new Depertment
                {
                    Id = 2,
                    Name = "Developer"
                }
                );
        }
    }
}