using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class MateriaProfessorEscolaMap : IEntityTypeConfiguration<MateriaProfessorEscola>
    {
        public void Configure(EntityTypeBuilder<MateriaProfessorEscola> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("MateriaProfessorEscola");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.Materia).WithMany(t => t.MateriasProfessores).HasForeignKey(t => t.MateriaId);
            builder.HasOne(t => t.ProfessorEscola).WithMany(t => t.MateriasProfessores).HasForeignKey(t => t.ProfessorEscolaId);

        }
    }
}
