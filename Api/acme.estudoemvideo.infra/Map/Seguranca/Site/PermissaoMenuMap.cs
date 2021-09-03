using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.Seguranca.Site
{
    public class PermissaoMenuMap : IEntityTypeConfiguration<PermissaoMenu>
    {
        public void Configure(EntityTypeBuilder<PermissaoMenu> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("PermissaoMenu");


            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

        }
    }
}
