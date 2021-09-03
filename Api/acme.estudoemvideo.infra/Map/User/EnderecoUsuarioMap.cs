using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.User
{
    public class EnderecoUsuarioMap : IEntityTypeConfiguration<EnderecoUsuario>
    {
        public void Configure(EntityTypeBuilder<EnderecoUsuario> builder)
        {
            builder.ToTable("EnderecoUsuario");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.DataCriacao);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Complemento).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Numero).IsRequired(true);
        }
    }
}
