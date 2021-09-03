using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Movie
{
    public class VideoMovieListMap : IEntityTypeConfiguration<VideoMovieList>
    {
        public void Configure(EntityTypeBuilder<VideoMovieList> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("MovieListVideo");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.DataLigacao).IsRequired(false);

        }
    }
}
