using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Util
{
    public class ParametroMap : IEntityTypeConfiguration<Parametro>
    {
        public void Configure(EntityTypeBuilder<Parametro> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Parametro");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Editar).HasDefaultValue(true).IsRequired(false);
            builder.Property(t => t.Descricao).HasMaxLength(900).IsRequired(true);
            builder.Property(t => t.Nome).HasMaxLength(255).IsRequired(true);
            builder.Property(t => t.Valor).HasMaxLength(500).IsRequired(true);
        }
    }
}
