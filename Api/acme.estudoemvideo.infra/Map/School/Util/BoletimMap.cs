using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class BoletimMap : IEntityTypeConfiguration<Boletim>
    {
        public void Configure(EntityTypeBuilder<Boletim> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Boletim");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.AlunoEscola).WithMany(t => t.Boletins).HasForeignKey(t => t.AlunoEscolaId);
            builder.HasOne(t => t.Materia).WithMany(t => t.Boletins).HasForeignKey(t => t.MateriaId);
            builder.HasOne(t => t.NotaAlunoMateriaProfessor).WithMany(t => t.Boletins).HasForeignKey(t => t.NotaAlunoMateriaProfessorId);
            builder.HasOne(t => t.ProfessorEscola).WithMany(t => t.Boletins).HasForeignKey(t => t.ProfessorEscolaId);
        }
    }
}
