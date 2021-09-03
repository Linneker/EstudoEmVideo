using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.Management.Administration;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.DTO.Negocio;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.School.Matter;
using acme.estudoemvideo.domain.DTO.School.Matter.Books;
using acme.estudoemvideo.domain.DTO.School.Notes;
using acme.estudoemvideo.domain.DTO.School.Question;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.Seguranca;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.Diary;
using acme.estudoemvideo.util.ViewModel.Management.Administration;
using acme.estudoemvideo.util.ViewModel.Movie;
using acme.estudoemvideo.util.ViewModel.Movie.Util;
using acme.estudoemvideo.util.ViewModel.Negocio;
using acme.estudoemvideo.util.ViewModel.Notificacao;
using acme.estudoemvideo.util.ViewModel.School;
using acme.estudoemvideo.util.ViewModel.School.Matter;
using acme.estudoemvideo.util.ViewModel.School.Matter.Books;
using acme.estudoemvideo.util.ViewModel.School.Notes;
using acme.estudoemvideo.util.ViewModel.School.Question;
using acme.estudoemvideo.util.ViewModel.School.Util;
using acme.estudoemvideo.util.ViewModel.Seguranca;
using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using acme.estudoemvideo.util.ViewModel.User;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.Map
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() : this("MyProfile")
        {
        }
        protected AutoMapperConfig(string profileName) : base(profileName)
        {
            CreateMap<AbstractEntity, AbstractEntityViewModel>();
            CreateMap<AbstractEntityViewModel, AbstractEntity> ();

            CreateMap<Log<object>, LogViewModel<object>>();
            CreateMap<LogViewModel<object>,Log<object>>();
            
            CreateMap<ResponseApi, RespostaPadraoModels>();
            CreateMap<RespostaPadraoModels, ResponseApi>();

            CreateMap<Notification, NotificationViewModel>();
            CreateMap<NotificationViewModel, Notification>();
            
          
            CreateMap<NotificationBaseViewModel, NotificationBase>();
            CreateMap<NotificationBase,NotificationBaseViewModel>();

            AutoMapperDiary();
            AutoMapperManagement();
            AutoMapperMovie();
            AutoMapperNegocio();
            AutoMapperSchool();
            AutoMapperSeguranca();
            AutoMapperUser();
            AutoMapperUtil();
        }

        private void AutoMapperDiary()
        {
            CreateMap<Agenda, AgendaViewModel>();
            CreateMap<AgendaViewModel, Agenda>();

            CreateMap<AnoLetivo, AnoLetivoViewModel>();
            CreateMap<AnoLetivoViewModel, AnoLetivo>();

            CreateMap<MateriaAgenda, MateriaAgendaViewModel>();
            CreateMap<MateriaAgendaViewModel, MateriaAgenda>();
        }

        private void AutoMapperManagement()
        {
            AutoMapperAdministration();
        }
        private void AutoMapperAdministration()
        {
            CreateMap<Despesa, DespesaViewModel>();
            CreateMap<DespesaViewModel, Despesa>();

            CreateMap<FluxoDeCaixaDespesa, FluxoDeCaixaDespesaViewModel>();
            CreateMap<FluxoDeCaixaDespesaViewModel, FluxoDeCaixaDespesa>();

            CreateMap<FluxoDeCaixaReceita, FluxoDeCaixaReceitaViewModel>();
            CreateMap<FluxoDeCaixaReceitaViewModel, FluxoDeCaixaReceita>();

            CreateMap<FluxoDeCaixa, FluxoDeCaixaViewModel>();
            CreateMap<FluxoDeCaixaViewModel, FluxoDeCaixa>();

            CreateMap<Receita, ReceitaViewModel>();
            CreateMap<ReceitaViewModel, Receita>();
        }

        private void AutoMapperMovie()
        {
            AutoMapperMoviewUtil();
            CreateMap<CategoriaVideo, CategoriaVideoViewModel>();
            CreateMap<CategoriaVideoViewModel, CategoriaVideo>();

            CreateMap<MovieListUsuario, MovieListUsuarioViewModel>();
            CreateMap<MovieListUsuarioViewModel, MovieListUsuario>();

            CreateMap<MovieList, MovieListViewModel>();
            CreateMap<MovieListViewModel, MovieList>();

            CreateMap<VideoMovieListViewModel, VideoMovieList>();
            CreateMap<VideoMovieList, VideoMovieListViewModel>();

            CreateMap<Video, VideoViewModel>();
            CreateMap<VideoViewModel, Video>();

            CreateMap<VotoVideo, VotoVideoViewModel>();
            CreateMap<VotoVideoViewModel, VotoVideo>();
        }
        private void AutoMapperMoviewUtil()
        {
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<CategoriaViewModel, Categoria>();
        }

        private void AutoMapperNegocio()
        {
            CreateMap<Empresa, EmpresaViewModel>();
            CreateMap<EmpresaViewModel,Empresa>();

            CreateMap<EnderecoEmpresa, EnderecoEmpresaViewModel>();
            CreateMap<EnderecoEmpresaViewModel, EnderecoEmpresa>();
        }

        private void AutoMapperSchool()
        {
            AutoMapperMatter();
            AutoMapperNotes();
            AutoMapperQuestion();
            AutoMapperSchoolUtil();

            CreateMap<AlunoEscola, AlunoEscolaViewModel>();
            CreateMap<AlunoEscolaViewModel, AlunoEscola>();

            CreateMap<Escola, EscolaViewModel>();
            CreateMap<EscolaViewModel, Escola>();

            CreateMap<ProfessorEscola, ProfessorEscolaViewModel>();
            CreateMap<ProfessorEscolaViewModel, ProfessorEscola>();

            CreateMap<Turma, TurmaViewModel>();
            CreateMap<TurmaViewModel, Turma>();
        }
        private void AutoMapperMatter()
        {
            AutoMapperBooks();
            CreateMap<ConteudoMateria, ConteudoMateriaViewModel>();
            CreateMap<ConteudoMateriaViewModel, ConteudoMateria>();

            CreateMap<Conteudo, ConteudoViewModel>();
            CreateMap<ConteudoViewModel, Conteudo>();

            CreateMap<Materia, MateriaViewModel>();
            CreateMap<MateriaViewModel, Materia>();
        }
        private void AutoMapperBooks()
        {
            CreateMap<Apostila, ApostilaViewModel>();
            CreateMap<ApostilaViewModel, Apostila> ();
            
            CreateMap<Livro, LivroViewModel>();
            CreateMap<LivroViewModel, Livro>();

        }
        private void AutoMapperNotes()
        {
            CreateMap<NotaAlunoMateriaConteudo, NotaAlunoMateriaConteudoViewModel>();
            CreateMap<NotaAlunoMateriaConteudoViewModel, NotaAlunoMateriaConteudo>();

            CreateMap<NotaAlunoMateriaProfessor, NotaAlunoMateriaProfessorViewModel>();
            CreateMap<NotaAlunoMateriaProfessorViewModel, NotaAlunoMateriaProfessor>();

            CreateMap<Nota, NotaViewModel>();
            CreateMap<NotaViewModel, Nota>();
        }
        private void AutoMapperQuestion()
        {
            CreateMap<PerguntaQuestionario, PerguntaQuestionarioViewModel>();
            CreateMap<PerguntaQuestionarioViewModel, PerguntaQuestionario>();
            
            CreateMap<Pergunta, PerguntaViewModel>();
            CreateMap<PerguntaViewModel, Pergunta>();

            CreateMap<Questionario, QuestionarioViewModel>();
            CreateMap<QuestionarioViewModel, Questionario>();

            CreateMap<Resposta, RespostaViewModel>();
            CreateMap<RespostaViewModel, Resposta>();

        }
        private void AutoMapperSchoolUtil()
        {
            CreateMap<BimestreViewModel, Bimestre>();
            CreateMap<Bimestre, BimestreViewModel>();

            CreateMap<EnderecoEscola, EnderecoEscolaViewModel>();
            CreateMap<EnderecoEscolaViewModel, EnderecoEscola>();

            CreateMap<FrequenciaAlunoMateria, FrequenciaAlunoMateriaViewModel>();
            CreateMap<FrequenciaAlunoMateriaViewModel, FrequenciaAlunoMateria>();

            CreateMap<Serie, SerieViewModel>();
            CreateMap<SerieViewModel, SerieViewModel>();

            CreateMap<TurmaAlunoEscola, TurmaAlunoEscolaViewModel>();
            CreateMap<TurmaAlunoEscolaViewModel, TurmaAlunoEscola>();

            CreateMap<TurmaProfessorEscola, TurmaProfessorEscolaViewModel>();
            CreateMap<TurmaProfessorEscolaViewModel, TurmaProfessorEscola>();

            CreateMap<TurmaMateria, TurmaMateriaViewModel>();
            CreateMap<TurmaMateriaViewModel, TurmaMateria>();

            CreateMap<MateriaProfessorEscola,          MateriaProfessorEscolaViewModel>();
            CreateMap<MateriaProfessorEscolaViewModel, MateriaProfessorEscola>();
        }

        private void AutoMapperSeguranca()
        {
            AutoMapperSegurancaSite();
            CreateMap<AutorizacaoApi, AutorizacaoApiViewModel>();
            CreateMap<AutorizacaoApiViewModel, AutorizacaoApi>();

        }
        private void AutoMapperSegurancaSite()
        {
            CreateMap<PermissaoConta, PermissaoContaViewModel>();
            CreateMap<PermissaoContaViewModel, PermissaoConta>();
            
            CreateMap<List<PermissaoContaViewModel>, List<PermissaoConta>>();
            CreateMap<List<PermissaoContaViewModel>, List<PermissaoConta>>();

            CreateMap<PermissaoMenu, PermissaoMenuViewModel>();
            CreateMap<PermissaoMenuViewModel, PermissaoMenu>();

            CreateMap<Permissao, PermissaoViewModel>();
            CreateMap<PermissaoViewModel, Permissao>();
        }

        private void AutoMapperUser()
        {
            CreateMap<Conta, ContaViewModel>();
            CreateMap<ContaViewModel, Conta>();

            CreateMap<EnderecoUsuario, EnderecoUsuarioViewModel>();
            CreateMap<EnderecoUsuarioViewModel, EnderecoUsuario>();

            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<UsuarioViewModel, Usuario>();

        }
        private void AutoMapperUtil()
        {
            CreateMap<Arquivo, ArquivoViewModel>();
            CreateMap<ArquivoViewModel, Arquivo>();

            CreateMap<Competencia, CompetenciaViewModel>();
            CreateMap<CompetenciaViewModel, Competencia>();

            CreateMap<Email, EmailViewModel>();
            CreateMap<EmailViewModel, Email>();

            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<EnderecoViewModel, Endereco>();

            CreateMap<Menu, MenuViewModel>();
            CreateMap<MenuViewModel, Menu>();

            CreateMap<Parametro, ParametroViewModel>();
            CreateMap<ParametroViewModel, Parametro>();
        }

    }
}
