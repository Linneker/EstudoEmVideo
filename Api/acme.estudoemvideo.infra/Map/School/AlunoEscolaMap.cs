using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School
{
    public class AlunoEscolaMap : IEntityTypeConfiguration<AlunoEscola>
    {
        public void Configure(EntityTypeBuilder<AlunoEscola> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("AlunoEscola");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.DataMatriculaAlunoNaEscola).IsRequired(true);
            builder.Property(t => t.DataAlunoEscola).HasDefaultValue(DateTime.Now);
            builder.Property(t => t.Matricula).IsRequired(true);
        }
    }
}
