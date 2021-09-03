using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Matter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Matter
{
    public class ConteudoMateriaMap : IEntityTypeConfiguration<ConteudoMateria>
    {
        public void Configure(EntityTypeBuilder<ConteudoMateria> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("ConteudoMateria");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.Materia).WithMany(t => t.ConteudosMaterias).HasForeignKey(T => T.MateriaId);
            builder.HasOne(t => t.Conteudo).WithMany(t => t.ConteudosMaterias).HasForeignKey(T => T.ConteudoId);
        }
    }
}
