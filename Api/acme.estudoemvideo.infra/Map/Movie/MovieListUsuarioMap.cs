using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Movie
{
    public class MovieListUsuarioMap : IEntityTypeConfiguration<MovieListUsuario>
    {
        public void Configure(EntityTypeBuilder<MovieListUsuario> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("MovieListUsuario");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Download).IsRequired(false).HasDefaultValue(false);
            builder.Property(t => t.Favorito).IsRequired(false).HasDefaultValue(false);
            builder.Property(t => t.DataCriacao).IsRequired(false);

        }
    }
}
