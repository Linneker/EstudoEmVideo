using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Diary
{
    public class AnoLetivoMap : IEntityTypeConfiguration<AnoLetivo>
    {
        public void Configure(EntityTypeBuilder<AnoLetivo> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("AnoLetivo");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Ano);
            builder.Property(t => t.Mes);
            builder.Property(t => t.Dia);
            builder.Property(t => t.DiaLetivo).HasDefaultValue(true);
            builder.Property(t => t.FeiradoEscolar).HasDefaultValue(false);
            builder.Property(t => t.FeiradoEstadual).HasDefaultValue(false);
            builder.Property(t => t.FeiradoMunicipal).HasDefaultValue(false);
            builder.Property(t => t.FeiradoNacional).HasDefaultValue(false);

        }
    }
}
