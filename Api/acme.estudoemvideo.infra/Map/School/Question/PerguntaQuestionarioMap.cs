using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Question;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Question
{
    public class PerguntaQuestionarioMap : IEntityTypeConfiguration<PerguntaQuestionario>
    {
        public void Configure(EntityTypeBuilder<PerguntaQuestionario> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("PerguntaQuestionario");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.DataVinculo);
            builder.HasOne(t => t.Pergunta).WithMany(t => t.PerguntasQuestionarios).HasForeignKey(t => t.PerguntaId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.Questionario).WithMany(t => t.PerguntasQuestionarios).HasForeignKey(t => t.QuestionarioId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(t => t.Resposta).WithMany(t => t.PerguntasQuestionarios).HasForeignKey(t => t.RespostaId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
