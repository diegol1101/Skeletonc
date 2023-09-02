

using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Persistencia.Data.Configuration;

    public class TrainerSalonConfiguracion : IEntityTypeConfiguration<TrainerSalon>
    {
        public void Configure(EntityTypeBuilder<TrainerSalon> builder)
        {
            builder.ToTable("trainersalon");

            builder.HasOne(p=> p.Persona)
            .WithMany(p=> p.TrainerSalones)
            .HasForeignKey(p=> p.IdPerTrainerFk);

            builder.HasOne(p=> p.Salon)
            .WithMany(p=> p.TrainesSalones)
            .HasForeignKey(p=> p.IdSalonFk);
        }
    }
