using System.Data.Entity;

namespace DAL.DAO
{
    public class Contexto : DbContext
    {
        const string connection = "GerenciadorEmpresarialConnectionString";

        public Contexto() : base(connection)
        { }

        // Entidades Mapeadas
        public DbSet<Models.Autorizacao> Autorizacoes { get; set; }

        public DbSet<Models.EstadoDaAutorizacao> EstadoDasAutorizacoes { get; set; }

        public DbSet<Models.Cargo> Cargos { get; set; }

        public DbSet<Models.Colaborador> Colaboradores { get; set; }

        public DbSet<Models.Departamento> Departamentos { get; set; }

        public DbSet<Models.Salario> Salarios { get; set; }

        public DbSet<Models.Mes> Meses { get; set; }

        public DbSet<Models.Tarefa> Tarefas { get; set; }

        public DbSet<Models.EstadoDaTarefa> EstadoDasTarefas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(Contexto).Assembly);
            modelBuilder.Conventions.Remove();

            //new AutorizacaoBuilder(modelBuilder.Entity<Models.Autorizacao>());
        }
    }
}