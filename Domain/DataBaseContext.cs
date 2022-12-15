using Domain.configrations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DepertmentConfigration());
            modelBuilder.ApplyConfiguration(new EmployeeConfigration());
        }

        public DbSet<Depertment> depertments { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}