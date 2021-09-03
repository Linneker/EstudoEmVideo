using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Movie
{
    public class VotoVideoMap : IEntityTypeConfiguration<VotoVideo>
    {
        public void Configure(EntityTypeBuilder<VotoVideo> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("VotoVideo");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.LikeRelevancia).IsRequired(true);
            builder.Property(t => t.Observacao).HasMaxLength(2500);
            builder.Property(t => t.QuantidadeLike);
        }
    }
}
