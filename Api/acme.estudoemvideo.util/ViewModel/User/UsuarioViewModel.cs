using acme.estudoemvideo.domain.DTO.Management.Administration;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel.Management.Administration;
using acme.estudoemvideo.util.ViewModel.Movie;
using acme.estudoemvideo.util.ViewModel.School;
using acme.estudoemvideo.util.ViewModel.School.Question;
using acme.estudoemvideo.util.ViewModel.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.User
{
    public class UsuarioViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Usuario", TITULO_MODAL = "USUARIO", URL_DOIS = "/Usuario/GetDadosTable", ID_TABLE = "tabela_usuario", CAMPOS_TABELA = "";

        public UsuarioViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            Contas = new HashSet<Conta>();
            MovieListUsuarios = new HashSet<MovieListUsuarioViewModel>();
            EnderecoUsuarios = new HashSet<EnderecoUsuarioViewModel>();
            Logs = new HashSet<Log<object>>();
            AlunosEscolas = new HashSet<AlunoEscolaViewModel>();
            Questionarios= new HashSet<QuestionarioViewModel>();
            Receitas = new HashSet<ReceitaViewModel>();
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataDeNascimento { get; set; }

        public bool DadosModificado { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }
        public virtual ICollection<MovieListUsuarioViewModel> MovieListUsuarios { get; set; }
        public virtual ICollection<EnderecoUsuarioViewModel> EnderecoUsuarios { get; set; }
        public virtual ICollection<Log<object>> Logs{ get; set; }
        public virtual ICollection<AlunoEscolaViewModel> AlunosEscolas { get; set; }
        public virtual ICollection<QuestionarioViewModel> Questionarios { get; set; }
        public virtual ICollection<ReceitaViewModel> Receitas{ get; set; }

    }
}
