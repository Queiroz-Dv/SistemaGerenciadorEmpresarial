using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.DAL.EntitiesConfiguration
{
    public class DepartamentoConfiguracao : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasKey(k => k.DepartamentoId);

            builder.Property(p => p.DepartamentoNome)
                   .HasMaxLength(50)
                   .IsRequired(true);
        }
    }
}
