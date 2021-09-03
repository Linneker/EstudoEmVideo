using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Seguranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Seguranca
{
    public class AutorizacaoApiMap : IEntityTypeConfiguration<AutorizacaoApi>
    {
        public void Configure(EntityTypeBuilder<AutorizacaoApi> builder)
        {
            builder.HasKey(t => t.Id);
            builder.ToTable("AutorizacaoApi");

            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.AccessKey).IsRequired().HasMaxLength(32);
            builder.Property(t => t.CnpjEmpresa).IsRequired().HasMaxLength(16);

        }
    }
}
