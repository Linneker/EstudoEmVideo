using acme.estudoemvideo.domain.DTO.Diary;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.DTO.Movie.Util;
using acme.estudoemvideo.domain.DTO.Negocio;
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
using acme.estudoemvideo.infra.Map.Diary;
using acme.estudoemvideo.infra.Map.Movie;
using acme.estudoemvideo.infra.Map.Movie.Util;
using acme.estudoemvideo.infra.Map.Negocio;
using acme.estudoemvideo.infra.Map.School;
using acme.estudoemvideo.infra.Map.School.Matter;
using acme.estudoemvideo.infra.Map.School.Matter.Books;
using acme.estudoemvideo.infra.Map.School.Notes;
using acme.estudoemvideo.infra.Map.School.Question;
using acme.estudoemvideo.infra.Map.School.Util;
using acme.estudoemvideo.infra.Map.Seguranca;
using acme.estudoemvideo.infra.Map.Seguranca.Site;
using acme.estudoemvideo.infra.Map.User;
using acme.estudoemvideo.infra.Map.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.infra.Config
{
    public class Context : DbContext
    {

        public Context()
        {
        }

        public Context(DbContextOptions<Context> connString) : base(connString)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder)
        {
            contextOptionsBuilder.UseMySQL("server=bd.thor.hostazul.com.br;Port=4406;database=105_estudoemvideo;user=105_estudoemvideo;password=asDr3$@efF#7");
        }

        public DbSet<AutorizacaoApi> AutorizacoesApi { get; set; }
        public DbSet<CategoriaVideo> CategoriasVideos { get; set; }
        public DbSet<MovieList> MovieLists { get; set; }
        public DbSet<VideoMovieList> VideoMovieLists { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<VotoVideo> VotosVideos { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<PermissaoConta> PermissoesContas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<MovieListUsuario> MovieListUsuarios { get; set; }
        public DbSet<Log<object>> Log { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
        public DbSet<Escola> Escolas { get; set; }
       // public DbSet<EnderecoEmpresa> EnderecoEmpresas{ get; set; }
        public DbSet<EnderecoEscola> EnderecoEscolas { get; set; }

        public DbSet<AlunoEscola> AlunoEscolas { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<PermissaoMenu> PermissaoMenus { get; set; }
        public DbSet<ProfessorEscola> ProfessorEscolas { get; set; }

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<AnoLetivo> AnoLetivos { get; set; }
        public DbSet<MateriaAgenda> MateriaAgendas { get; set; }
        public DbSet<Diario> Diarios { get; set; }

        public DbSet<Apostila> Apostilas { get; set; }
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Conteudo> Conteudos { get; set; }
        public DbSet<ConteudoMateria> ConteudoMaterias { get; set; }
        public DbSet<Materia> Materias { get; set; }

        public DbSet<NotaAlunoMateriaConteudo> NotaAlunoMateriaConteudos { get; set; }
        public DbSet<NotaAlunoMateriaProfessor> NotaAlunoMateriaProfessores { get; set; }
        public DbSet<Nota> Notas { get; set; }

        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<PerguntaQuestionario> PerguntaQuestionarios { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<Resposta> Respostas { get; set; }

        public DbSet<Bimestre> Bimestres { get; set; }
        public DbSet<Boletim> Boletins { get; set; }
        public DbSet<FrequenciaAlunoMateria> FrequenciaAlunoMaterias { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<TurmaAlunoEscola> TurmaAlunoEscolas { get; set; }
        public DbSet<TurmaProfessorEscola> TurmaProfessorEscolas { get; set; }
        public DbSet<TurmaBimestre> TurmaBimestres { get; set; }
        public DbSet<TurmaProfessorEscola> TurmaProfessoresEscolas { get; set; }
        public DbSet<MateriaProfessorEscola> MateriaProfessorEscolas { get; set; }
        public DbSet<AlunoEscolaDiario> AlunosEscolasDiarios { get; set; }
        public DbSet<ProfessorEscolaDiario> ProfessorEscolaDiarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EnderecoUsuario> EnderecoUsuarios { get; set; }
        public DbSet<Arquivo> Arquivos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder = PreencheMapDiary(modelBuilder);
            modelBuilder = PreencheMapSchool(modelBuilder);
            modelBuilder = PreencheMapUtil(modelBuilder);
            

            modelBuilder.ApplyConfiguration<CategoriaVideo>(new CategoriaVideoMap());
            modelBuilder.ApplyConfiguration<MovieList>(new MovieListMap());
            modelBuilder.ApplyConfiguration<VideoMovieList>(new VideoMovieListMap());
            modelBuilder.ApplyConfiguration<Video>(new VideoMap());
            modelBuilder.ApplyConfiguration<VotoVideo>(new VotoVideoMap());
            modelBuilder.ApplyConfiguration<Conta>(new ContaMap());
            modelBuilder.ApplyConfiguration<Permissao>(new PermissaoMap());
            modelBuilder.ApplyConfiguration<PermissaoConta>(new PermissaoContaMap());
            modelBuilder.ApplyConfiguration<Usuario>(new UsuarioMap());
            modelBuilder.ApplyConfiguration<EnderecoUsuario>(new EnderecoUsuarioMap());
            modelBuilder.ApplyConfiguration<Categoria>(new CategoriaMap());
            modelBuilder.ApplyConfiguration<MovieListUsuario>(new MovieListUsuarioMap());
            modelBuilder.ApplyConfiguration<AutorizacaoApi>(new AutorizacaoApiMap());
            modelBuilder.ApplyConfiguration<PermissaoMenu>(new PermissaoMenuMap());

            //modelBuilder.ApplyConfiguration(new EmpresaMap());
            //modelBuilder.ApplyConfiguration(new EnderecoEmpresaMap());
        }

        private ModelBuilder PreencheMapUtil(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Log<object>>(new LogMap<object>());
            modelBuilder.ApplyConfiguration<Parametro>(new ParametroMap());
            modelBuilder.ApplyConfiguration<Arquivo>(new ArquivoMap());
            modelBuilder.ApplyConfiguration<Menu>(new MenuMap());
            modelBuilder.ApplyConfiguration<Endereco>(new EnderecoMap());
            return modelBuilder;
        }

        private ModelBuilder PreencheMapSchool(ModelBuilder modelBuilder)
        {
            modelBuilder = PreencheMapMatter(modelBuilder);
            modelBuilder = PreencheMapNotes(modelBuilder);
            modelBuilder = PreencheMapQuestion(modelBuilder);
            modelBuilder = PreencheMapSchoolUtil(modelBuilder);

            modelBuilder.ApplyConfiguration<Escola>(new EscolaMap());
            modelBuilder.ApplyConfiguration<AlunoEscola>(new AlunoEscolaMap());
            modelBuilder.ApplyConfiguration(new ProfessorEscolaMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());

            return modelBuilder;
        }

        private ModelBuilder PreencheMapSchoolUtil(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BimestreMap());
            modelBuilder.ApplyConfiguration(new FrequenciaAlunoMateriaMap());
            modelBuilder.ApplyConfiguration(new SerieMap());
            modelBuilder.ApplyConfiguration(new TurmaAlunoEscolaMap());
            modelBuilder.ApplyConfiguration(new TurmaProfessorEscolaMap());
            modelBuilder.ApplyConfiguration(new TurmaMateriaMap());
            modelBuilder.ApplyConfiguration(new MateriaProfessorEscolaMap());
            modelBuilder.ApplyConfiguration(new EnderecoEscolaMap());
            modelBuilder.ApplyConfiguration(new TurmaBimestreMap());
            modelBuilder.ApplyConfiguration(new BoletimMap());
            modelBuilder.ApplyConfiguration(new AlunoEscolaDiarioMap());
            modelBuilder.ApplyConfiguration(new ProfessorEscolaDiarioMap());

            return modelBuilder;
        }

        private ModelBuilder PreencheMapQuestion(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PerguntaMap());
            modelBuilder.ApplyConfiguration(new PerguntaQuestionarioMap());
            modelBuilder.ApplyConfiguration(new QuestionarioMap());
            modelBuilder.ApplyConfiguration(new RespostaMap());

            return modelBuilder;
        }

        private ModelBuilder PreencheMapNotes(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new NotaAlunoMateriaConteudoMap());
            modelBuilder.ApplyConfiguration(new NotaAlunoMateriaProfessorMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            return modelBuilder;
        }

        private ModelBuilder PreencheMapMatter(ModelBuilder modelBuilder)
        {
            modelBuilder = PreencheMapBooks(modelBuilder);
            modelBuilder.ApplyConfiguration(new ConteudoMap());
            modelBuilder.ApplyConfiguration(new ConteudoMateriaMap());
            modelBuilder.ApplyConfiguration(new MateriaMap());

            return modelBuilder;
        }

        private ModelBuilder PreencheMapBooks(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApostilaMap());
            modelBuilder.ApplyConfiguration(new LivroMap());
            return modelBuilder;
        }

        private ModelBuilder PreencheMapDiary(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendaMap());
            modelBuilder.ApplyConfiguration(new AnoLetivoMap());
            modelBuilder.ApplyConfiguration(new MateriaAgendaMap());
            modelBuilder.ApplyConfiguration(new DiarioMap());

            return modelBuilder;
        }
    }
}
