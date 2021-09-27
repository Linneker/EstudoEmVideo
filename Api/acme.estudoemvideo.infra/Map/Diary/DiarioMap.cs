using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Diary
{
    public class DiarioMap : IEntityTypeConfiguration<Diario>
    {
        public void Configure(EntityTypeBuilder<Diario> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Diario");

            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.AnoLetivo).WithMany(t => t.Diarios).HasForeignKey(t => t.AnoLetivoId);
        }
    }
}
