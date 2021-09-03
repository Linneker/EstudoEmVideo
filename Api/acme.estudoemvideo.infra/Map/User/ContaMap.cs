using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.User
{
    public class ContaMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Conta");

            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.AlterarSenha).HasDefaultValue(false).IsRequired(false);
            builder.Property(t => t.ContaAtiva).HasDefaultValue(true).IsRequired(false);
            builder.Property(t => t.Login).HasMaxLength(500).IsRequired(true);
            builder.Property(t => t.Senha).HasMaxLength(500).IsRequired(true);
        }
    }
}
