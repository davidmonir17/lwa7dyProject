using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Implimentation;
using Repository.Interfaces;
using Service.Implemtaion;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lwa7dyProject.ExtinstionMethod
{
    public static class ServiceExtintions
    {
        public static void sqlconfigration(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<DataBaseContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("sqlconnection"), b => b.MigrationsAssembly("lwa7dyProject"));
            });
        }

        public static void RepositoryMgrConfig(this IServiceCollection services) =>
                        services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ServicerConfig(this IServiceCollection services)
        {
            services.AddScoped<IDepertmentService, DepertmentService>();
            // services.AddScoped<IEmployeeService , DepertmentService>();
        }
    }
}