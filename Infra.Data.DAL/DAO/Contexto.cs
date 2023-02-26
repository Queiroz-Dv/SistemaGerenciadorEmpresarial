using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.DAL.DAO
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        // Entidades Mapeadas

        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);
        }
    }
}