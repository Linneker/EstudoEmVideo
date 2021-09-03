using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Util
{
    public class FrequenciaAlunoMateriaMap : IEntityTypeConfiguration<FrequenciaAlunoMateria>
    {
        public void Configure(EntityTypeBuilder<FrequenciaAlunoMateria> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("FrequenciaAlunoMateria");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.JustificativaFalta);
            builder.Property(t => t.QuantidadeFalta).HasDefaultValue(0);
            builder.Property(t => t.QuantidadeFaltaJustificada).HasDefaultValue(0);
            builder.Property(t => t.QuantidadePresenca).HasDefaultValue(0);

            builder.HasOne(t => t.Agenda).WithMany(t => t.FrequenciasAlunosMaterias).HasForeignKey(t => t.AgendaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.AlunoEscola).WithMany(t => t.FrequenciasAlunosMaterias).HasForeignKey(t => t.AlunoEscolaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.Materia).WithMany(t => t.FrequenciasAlunosMaterias).HasForeignKey(t => t.MateriaId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
