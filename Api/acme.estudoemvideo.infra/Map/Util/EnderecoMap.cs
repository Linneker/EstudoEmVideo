using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Util
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Endereco");
            builder.Property(t => t.DataCriacao);
            builder.Property(t => t.DataModificacao);
            builder.Property(t => t.DataInativacao);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Cep).HasMaxLength(15).IsRequired();
            builder.HasIndex(t => t.Cep).IsUnique(true);
            builder.Property(t => t.Pais).HasMaxLength(300).IsRequired(false);
            builder.Property(t => t.Estado).HasMaxLength(255);
            builder.Property(t => t.Cidade).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Bairro).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Rua).HasMaxLength(255).IsRequired();
        }
    }
}
