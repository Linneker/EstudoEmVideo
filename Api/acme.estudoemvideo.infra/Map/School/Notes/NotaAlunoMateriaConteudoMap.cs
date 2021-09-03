using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Notes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Notes
{
    public class NotaAlunoMateriaConteudoMap : IEntityTypeConfiguration<NotaAlunoMateriaConteudo>
    {
        public void Configure(EntityTypeBuilder<NotaAlunoMateriaConteudo> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("NotaAlunoMateriaConteudo");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);
             

            builder.HasOne(t => t.Conteudo).WithMany(t => t.NotaAlunoMateriaConteudos).HasForeignKey(t => t.ConteudoId);
            builder.HasOne(t => t.NotaAlunoMateria).WithMany(t => t.NotaAlunoMateriaConteudos).HasForeignKey(t => t.NotaAlunoMateriaId);
        }
    }
}
