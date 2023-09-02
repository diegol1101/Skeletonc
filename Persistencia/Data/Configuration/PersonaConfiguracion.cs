
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration;

    public class PersonaConfiguracion : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            builder.Property(p=> p.Nombre)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p=> p.Apellido)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p=> p.Direccion)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(p=> p.Genero)
            .WithMany(p=> p.Personas)
            .HasForeignKey(p=> p.IdGeneroFk);

            builder.HasOne(p=> p.Ciudad)
            .WithMany(p=> p.Personas)
            .HasForeignKey(p=>p.IdCiudadFk);

            builder.HasOne(p=> p.TipoPersona)
            .WithMany(p=> p.Personas)
            .HasForeignKey(p=> p.IdTipoPersonaFk);

        }
    }
