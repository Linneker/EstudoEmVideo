using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class TurmaMateriaMap : IEntityTypeConfiguration<TurmaMateria>
    {
        public void Configure(EntityTypeBuilder<TurmaMateria> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("TurmaMateria");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.Turma).WithMany(t => t.TurmaMaterias).HasForeignKey(t => t.TurmaId);
            builder.HasOne(t => t.Materia).WithMany(t => t.TurmaMaterias).HasForeignKey(t => t.MateriaId);
            

        }
    }
}
