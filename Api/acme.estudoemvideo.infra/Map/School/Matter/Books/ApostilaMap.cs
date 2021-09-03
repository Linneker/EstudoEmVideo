using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Matter.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Matter.Books
{
    public class ApostilaMap : IEntityTypeConfiguration<Apostila>
    {
        public void Configure(EntityTypeBuilder<Apostila> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Apostila");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Bibliografia).HasMaxLength(255);

            builder.HasOne(t => t.Conteudo).WithMany(t => t.Apostilas).HasForeignKey(t => t.ConteudoId);

            builder.HasOne(t => t.Arquivo).WithMany(t => t.Apostilas).HasForeignKey(t => t.ArquivoId);
        }
    }
}
