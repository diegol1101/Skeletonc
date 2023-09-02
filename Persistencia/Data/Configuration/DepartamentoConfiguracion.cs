
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class DepartamentoConfiguracion : IEntityTypeConfiguration<Departamento>
    {
        public void Configure (EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("departamento");

            builder.Property(p=> p.NombreDepeartamento)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p=> p.Pais)
            .WithMany(p=> p.Departamentos)
            .HasForeignKey(p=>p.IdPaisFk);
        }
    }
