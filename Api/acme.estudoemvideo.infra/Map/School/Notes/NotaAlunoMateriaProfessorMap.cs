using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Notes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Notes
{
    public class NotaAlunoMateriaProfessorMap : IEntityTypeConfiguration<NotaAlunoMateriaProfessor>
    {
        public void Configure(EntityTypeBuilder<NotaAlunoMateriaProfessor> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("NotaAlunoMateriaProfessor");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);


            builder.HasOne(t => t.Materia).WithMany(t => t.NotasAlunosMateriasProfessores).HasForeignKey(t => t.MateriaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.Nota).WithMany(t => t.NotasAlunosMateriasProfessores).HasForeignKey(t => t.NotaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.ProfessorEscola).WithMany(t => t.NotasAlunosMateriasProfessores).HasForeignKey(t => t.ProfessorEscolaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.AlunoEscola).WithMany(t => t.NotasAlunosMateriasProfessores).HasForeignKey(t => t.AlunoEscolaId).OnDelete(DeleteBehavior.NoAction);

        }
    }
}
