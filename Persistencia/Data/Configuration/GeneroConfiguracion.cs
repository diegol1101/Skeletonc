
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class GeneroConfiguracion : IEntityTypeConfiguration<Genero>
    {
        
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("genero");

            builder.Property(p=> p.Descripcion)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
