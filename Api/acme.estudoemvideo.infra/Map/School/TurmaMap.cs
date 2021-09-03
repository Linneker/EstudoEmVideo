using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School
{
    public class TurmaMap : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Turma");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Nome).HasMaxLength(900);
            builder.Property(t => t.Periodo);
            
            builder.HasOne(t => t.Serie).WithMany(t => t.Turmas).HasForeignKey(t => t.SerieId);
            builder.HasOne(t => t.Escola).WithMany(t => t.Turmas).HasForeignKey(t => t.EscolaId);

        }
    }
}
