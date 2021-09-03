using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Util
{
    public class LogMap<TEntity> : IEntityTypeConfiguration<Log<TEntity>> where TEntity : class
    {
        public void Configure(EntityTypeBuilder<Log<TEntity>> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Log");

            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);


            builder.Property(t => t.DataLog).IsRequired(false);
            builder.Property(t => t.Descricao).HasMaxLength(900).IsRequired(true);
            builder.Property(t => t.ModificaoObjeto).HasMaxLength(900).IsRequired(false);
            builder.Property(t => t.Nome).HasMaxLength(500).IsRequired(false);
            builder.Property(t => t.ObjetoJson).HasMaxLength(900).IsRequired(true);
        }
    }
}
