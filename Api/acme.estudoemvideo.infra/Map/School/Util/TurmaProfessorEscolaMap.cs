using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class TurmaProfessorEscolaMap : IEntityTypeConfiguration<TurmaProfessorEscola>
    {
        public void Configure(EntityTypeBuilder<TurmaProfessorEscola> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("TurmaProfessorEscola");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.Turma).WithMany(t => t.TurmaProfessorEscolas).HasForeignKey(t => t.TurmaId);
            builder.HasOne(t => t.ProfessorEscola).WithMany(t => t.TurmaProfessorEscolas).HasForeignKey(t => t.ProfessorEscolaId);

        }
    }
}
