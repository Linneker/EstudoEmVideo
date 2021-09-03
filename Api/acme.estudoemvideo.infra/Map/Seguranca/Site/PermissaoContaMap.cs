using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Seguranca.Site
{
    public class PermissaoContaMap : IEntityTypeConfiguration<PermissaoConta>
    {
        public void Configure(EntityTypeBuilder<PermissaoConta> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("PermissaoConta");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);


        }
    }
}
