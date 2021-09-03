using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.Management.Administration;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.User
{
    public class Usuario : AbstractEntity
    {
        public Usuario()
        {
            Contas = new HashSet<Conta>();
            MovieListUsuarios = new HashSet<MovieListUsuario>();
            EnderecoUsuarios = new HashSet<EnderecoUsuario>();
            Logs = new HashSet<Log<object>>();
            AlunosEscolas = new HashSet<AlunoEscola>();
            Questionarios= new HashSet<Questionario>();
            Receitas = new HashSet<Receita>();
            VotoVideos = new HashSet<VotoVideo>();
            ProfessorEscolas = new HashSet<ProfessorEscola>();
            Respostas = new HashSet<Resposta>();
            Agendas = new HashSet<Agenda>();
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public bool DadosModificado { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }
        public virtual ICollection<MovieListUsuario> MovieListUsuarios { get; set; }
        public virtual ICollection<EnderecoUsuario> EnderecoUsuarios { get; set; }
        public virtual ICollection<Log<object>> Logs{ get; set; }
        public virtual ICollection<AlunoEscola> AlunosEscolas { get; set; }
        public virtual ICollection<Questionario> Questionarios { get; set; }
        public virtual ICollection<Receita> Receitas{ get; set; }
        public virtual ICollection<VotoVideo> VotoVideos { get; set; }
        public virtual ICollection<ProfessorEscola> ProfessorEscolas { get; set; }
        public virtual ICollection<Resposta> Respostas { get; set; }
        public virtual ICollection<Agenda> Agendas { get; set; }

    }
}
