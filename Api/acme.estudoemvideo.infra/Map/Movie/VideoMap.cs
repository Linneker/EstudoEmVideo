using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Movie
{
    public class VideoMap : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Video");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Nome).HasMaxLength(255).IsRequired(true);
            builder.Property(t => t.NomeArquivo).HasMaxLength(255).IsRequired(true);
            builder.Property(t => t.Descricao).HasMaxLength(300).IsRequired(false);

            builder.Property(t => t.Caminho).HasMaxLength(255).HasDefaultValue("~/Video/").IsRequired(false);
            builder.Property(t => t.EnumPopularidade).IsRequired(false);
            builder.Property(t => t.PopularidadeEmNumero).IsRequired(false);
            builder.Property(t => t.Visualizacao).IsRequired(false);
        }
    }
}
