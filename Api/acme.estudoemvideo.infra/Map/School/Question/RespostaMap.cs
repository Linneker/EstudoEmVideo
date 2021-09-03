using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School.Question;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Map.School.Question
{
    public class RespostaMap : IEntityTypeConfiguration<Resposta>
    {
        public void Configure(EntityTypeBuilder<Resposta> builder)
        {
            builder.HasKey(t => t.Id);

            builder.ToTable("Resposta");
            builder.Property(t => t.DataCriacao).IsRequired(false);
            builder.Property(t => t.DataModificacao).IsRequired(false);
            builder.Property(t => t.DataInativacao).IsRequired(false);
            builder.Property(t => t.Status).HasDefaultValue(EnumStatus.Ativo);

            builder.Property(t => t.Descricao);
            builder.Property(t => t.Relevancia);

            builder.HasOne(t => t.Pergunta).WithMany(t => t.Respostas).HasForeignKey(t => t.PerguntaId);
            builder.HasOne(t => t.Usuario).WithMany(t => t.Respostas).HasForeignKey(t => t.UsuarioId);
        }
    }
}
