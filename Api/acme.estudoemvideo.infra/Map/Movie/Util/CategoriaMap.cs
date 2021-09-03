using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.DTO.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Movie.Util
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Categoria");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Nome).HasMaxLength(255).IsRequired(true);
            builder.Property(t => t.Tipo).IsRequired(true);
        }
    }
}
