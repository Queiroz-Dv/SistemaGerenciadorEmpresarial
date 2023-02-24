using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.DAL.EntitiesConfiguration
{
    public class CargoConfiguracao : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.HasKey(k => k.CargoId);
            builder.Property(p => p.CargoNome)
                   .HasMaxLength(50)
                   .IsRequired(true);

            builder.HasMany(cargoDepartamentos => cargoDepartamentos.Departamentos)
                .WithOne(departamentoCargo => departamentoCargo.Cargo)
                .HasForeignKey(depart_Id => depart_Id.DepartamentoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
