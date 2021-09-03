using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.User
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Usuario");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Cpf).HasMaxLength(11).IsRequired(true);
            builder.Property(t => t.DataDeNascimento).IsRequired(true);
            builder.Property(t => t.Email).IsRequired(true).HasMaxLength(255);
            builder.Property(t => t.Nome).HasMaxLength(500).IsRequired(true);
            builder.Property(t => t.Telefone).HasMaxLength(14).IsRequired(true);

        }
    }
}
