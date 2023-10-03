using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M03S09.Jogos.WebApi.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M03S09.Jogos.WebApi.Infra.Configurations
{
    public class EstudioConfiguration : IEntityTypeConfiguration<Estudio>
    {
        public void Configure(EntityTypeBuilder<Estudio> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Id)
                .UseIdentityColumn();
                
            builder.ToTable("Estudios");

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(500)
                .HasColumnName("Nome");
            
            builder.Property(p => p.DataCriacao)
                .IsRequired();
        }
    }
}