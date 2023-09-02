

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class TipoPersonaConfiguracion : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("tipopersona");

            builder.Property(p => p.Descripcion)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
