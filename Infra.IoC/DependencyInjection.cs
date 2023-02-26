using Domain.Interfaces.InterfaceRepository;
using Infra.Data.DAL.DAO;
using Infra.Data.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<Contexto>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
            , b => b.MigrationsAssembly(typeof(Contexto).Assembly.FullName)));

            services.AddScoped<ICargoRepository, CargoRepository>();
            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();

            return services;
        }
    }
}
