using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class TurmaAlunoEscolaMap : IEntityTypeConfiguration<TurmaAlunoEscola>
    {
        public void Configure(EntityTypeBuilder<TurmaAlunoEscola> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("TurmaAlunoEscola");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.HasOne(t => t.Turma).WithMany(t => t.TurmasAlunosEscolas).HasForeignKey(t=>t.TurmaId);
            builder.HasOne(t => t.AlunoEscola).WithMany(t => t.TurmasAlunosEscolas).HasForeignKey(t => t.AlunoEscolaId);

        }
    }
}
