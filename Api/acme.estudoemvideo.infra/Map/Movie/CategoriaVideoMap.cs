using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Util
{
    public class CategoriaVideoMap : IEntityTypeConfiguration<CategoriaVideo>
    {
        public void Configure(EntityTypeBuilder<CategoriaVideo> builder)
        {

            builder.HasKey(t => t.Id);

            builder.ToTable("CategoriaVideo");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.DataCadastro).IsRequired(false);
        }
    }
}
