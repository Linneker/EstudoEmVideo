using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class EnderecoEscolaMap : IEntityTypeConfiguration<EnderecoEscola>
    {
        public void Configure(EntityTypeBuilder<EnderecoEscola> builder)
        {
            builder.ToTable("EnderecoEscola");

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
