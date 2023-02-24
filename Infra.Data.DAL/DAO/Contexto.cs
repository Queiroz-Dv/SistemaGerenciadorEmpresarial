using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.DAO
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }

        // Entidades Mapeadas

        public DbSet<Cargo> Cargos { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        //public DbSet<Autorizacao> Autorizacoes { get; set; }

        //public DbSet<EstadoDaAutorizacao> EstadoDasAutorizacoes { get; set; }


        //public DbSet<Colaborador> Colaboradores { get; set; }


        //public DbSet<Salario> Salarios { get; set; }

        //public DbSet<Mes> Meses { get; set; }

        //public DbSet<Tarefa> Tarefas { get; set; }

        //public DbSet<EstadoDaTarefa> EstadoDasTarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Contexto).Assembly);

        }
    }
}