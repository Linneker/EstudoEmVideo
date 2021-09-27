using acme.estudoemvideo.aplication.Aplication;
using acme.estudoemvideo.aplication.Aplication.Diary;
using acme.estudoemvideo.aplication.Aplication.Movie;
using acme.estudoemvideo.aplication.Aplication.Movie.Util;
using acme.estudoemvideo.aplication.Aplication.School;
using acme.estudoemvideo.aplication.Aplication.School.Matter;
using acme.estudoemvideo.aplication.Aplication.School.Notes;
using acme.estudoemvideo.aplication.Aplication.School.Util;
using acme.estudoemvideo.aplication.Aplication.Seguranca.Site;
using acme.estudoemvideo.aplication.Aplication.User;
using acme.estudoemvideo.aplication.Aplication.Util;
using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.Diary;
using acme.estudoemvideo.aplication.Interfaces.Movie;
using acme.estudoemvideo.aplication.Interfaces.Movie.Util;
using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.School.Notes;
using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Repository.Diary;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Repository.School.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.domain.Interfaces.Services;
using acme.estudoemvideo.domain.Interfaces.Services.Diary;
using acme.estudoemvideo.domain.Interfaces.Services.Movie;
using acme.estudoemvideo.domain.Interfaces.Services.Movie.Util;
using acme.estudoemvideo.domain.Interfaces.Services.School;
using acme.estudoemvideo.domain.Interfaces.Services.School.Matter;
using acme.estudoemvideo.domain.Interfaces.Services.School.Notes;
using acme.estudoemvideo.domain.Interfaces.Services.School.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca;
using acme.estudoemvideo.domain.Interfaces.Services.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Services.User;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using acme.estudoemvideo.domain.Services;
using acme.estudoemvideo.domain.Services.Diary;
using acme.estudoemvideo.domain.Services.Movie;
using acme.estudoemvideo.domain.Services.Movie.Util;
using acme.estudoemvideo.domain.Services.School;
using acme.estudoemvideo.domain.Services.School.Matter;
using acme.estudoemvideo.domain.Services.School.Notes;
using acme.estudoemvideo.domain.Services.School.Util;
using acme.estudoemvideo.domain.Services.Seguranca;
using acme.estudoemvideo.domain.Services.Seguranca.Site;
using acme.estudoemvideo.domain.Services.User;
using acme.estudoemvideo.domain.Services.Util;
using acme.estudoemvideo.infra.Repository;
using acme.estudoemvideo.infra.Repository.Diary;
using acme.estudoemvideo.infra.Repository.Movie;
using acme.estudoemvideo.infra.Repository.Movie.Util;
using acme.estudoemvideo.infra.Repository.School;
using acme.estudoemvideo.infra.Repository.School.Matter;
using acme.estudoemvideo.infra.Repository.School.Notes;
using acme.estudoemvideo.infra.Repository.School.Util;
using acme.estudoemvideo.infra.Repository.Seguranca;
using acme.estudoemvideo.infra.Repository.Seguranca.Site;
using acme.estudoemvideo.infra.Repository.User;
using acme.estudoemvideo.infra.Repository.Util;
using acme.estudoemvideo.services.Interfaces.Util;
using acme.estudoemvideo.services.Services.Util;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.InjectDependencie
{
    public class InjecaoDeDependencia
    {
        public IServiceCollection InjetaDependecia(IServiceCollection services)
        {
            services = InjetaDependenciaRepository(services);
            services = InjetaDependenciaServices(services);
            services = InjetaDependenciaApplication(services);

            return services;
        }

        public IServiceCollection InjetaDependenciaRepository(IServiceCollection services)
        {
            //Repository
            services.AddTransient<IRepositoryBase<AbstractEntity>, RepositoryBase<AbstractEntity>>();

            services.AddTransient<IAgendaRepository, AgendaRepository>();
            services.AddTransient<IAnoLetivoRepository, AnoLetivoRepository>();
            services.AddTransient<IDiarioRepository, DiarioRepository>();
            services.AddTransient<IMateriaAgendaRepository, MateriaAgendaRepository>();

            services.AddTransient<IMovieListRepository, MovieListRepository>();
            services.AddTransient<IMovieListUsuarioRepository, MovieListUsuarioRepository>();
            services.AddTransient<IVideoMovieListRepository, VideoMovieListRepository>();
            services.AddTransient<IVideoRepository, VideoRepository>();
            services.AddTransient<IVotoVideoRepository, VotoVideoRepository>();
            services.AddTransient<ICategoriaVideoRepository, CategoriaVideoRepository>();

            services.AddTransient<IContaRepository, ContaRepository>();
            services.AddTransient<IPermissaoContaRepository, PermissaoContaRepository>();
            services.AddTransient<IPermissaoRepository, PermissaoRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPermissaoMenuRepository, PermissaoMenuRepository>();

            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<ILogRepository<object>, LogRepository>();
            services.AddTransient<IPermissaoRepository, PermissaoRepository>();

            services.AddTransient<IAutorizacaoApiRepository, AutorizacaoApiRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();

            services.AddTransient<IBimestreRepository, BimestreRepository>();

            services.AddTransient<IAlunoEscolaRepository, AlunoEscolaRepository>();
            services.AddTransient<IProfessorEscolaRepository, ProfessorEscolaRepository>();
            services.AddTransient<IEscolaRepository, EscolaRepository>();
            services.AddTransient<ISerieRepository, SerieRepository>();
            services.AddTransient<ITurmaRepository, TurmaRepository>();
            services.AddTransient<IMateriaRepository, MateriaRepository>();
            services.AddTransient<IConteudoRepository, ConteudoRepository>();
            services.AddTransient<INotaRepository, NotaRepository>();
            services.AddTransient<IBoletimRepository, BoletimRepository>();
            services.AddTransient<INotaAlunoMateriaConteudoRepository, NotaAlunoMateriaConteudoRepository>();
            services.AddTransient<INotaAlunoMateriaProfessorRepository, NotaAlunoMateriaProfessorRepository>();

            services.AddTransient<IParametroRepository, ParametroRepository>();
            
            return services;
        }

        public IServiceCollection InjetaDependenciaServices(IServiceCollection services)
        {
            //Services
            services.AddTransient<IServicesBase<AbstractEntity>, ServiceBase<AbstractEntity>>();
            
            services.AddTransient<IAgendaServices, AgendaServices>();
            services.AddTransient<IAnoLetivoServices, AnoLetivoServices>();
            services.AddTransient<IDiarioServices, DiarioServices>();
            services.AddTransient<IMateriaAgendaServices, MateriaAgendaServices>();

            services.AddTransient<IMovieListServices, MovieListServices>();
            services.AddTransient<IMovieListUsuarioServices, MovieListUsuarioServices>();
            services.AddTransient<IVideoMovieListServices, VideoMovieListServices>();
            services.AddTransient<IVideoServices, VideoServices>();
            services.AddTransient<IVotoVideoServices, VotoVideoServices>();
            services.AddTransient<ICategoriaVideoServices, CategoriaVideoServices>();

            services.AddTransient<IContaServices, ContaServices>();
            services.AddTransient<IPermissaoContaServices, PermissaoContaServices>();
            services.AddTransient<IPermissaoServices, PermissaoServices>();
            services.AddTransient<IUsuarioServices, UsuarioServices>();

            services.AddTransient<ICategoriaServices, CategoriaServices>();
            services.AddTransient<ILogServices<object>, LogServices>();
            services.AddTransient<IPermissaoServices, PermissaoServices>();
            services.AddTransient<IPermissaoMenuServices, PermissaoMenuServices>();

            services.AddTransient<IAutorizacaoApiServices, AutorizacaoApiServices>();

            services.AddTransient<IBimestreServices, BimestreServices>();
            services.AddTransient<ISerieServices, SerieServices>();
            services.AddTransient<ITurmaServices, TurmaServices>();

            services.AddTransient<IEmailServices, EmailServices>();
            services.AddTransient<IMenuServices, MenuServices>();
            services.AddTransient<IAlunoEscolaServices, AlunoEscolaServices>();
            services.AddTransient<IProfessorEscolaServices, ProfessorEscolaServices>();
            services.AddTransient<IEscolaServices, EscolaServices>();
            services.AddTransient<IMateriaServices, MateriaServices>();
            services.AddTransient<IConteudoServices, ConteudoServices>();
            services.AddTransient<INotaServices, NotaServices>();
            services.AddTransient<IBoletimServices, BoletimServices>();
            services.AddTransient<INotaAlunoMateriaConteudoServices, NotaAlunoMateriaConteudoServices>();
            services.AddTransient<INotaAlunoMateriaProfessorServices, NotaAlunoMateriaProfessorServices>();

            services.AddTransient<IParametroServices, ParametroServices>();

            return services;
        }
    
    
        public IServiceCollection InjetaDependenciaApplication(IServiceCollection services)
        {
            //Aplication
            services.AddTransient<IApplicationBase<AbstractEntity>, ApplicationBase<AbstractEntity>>();

            services.AddTransient<IAgendaApplication, AgendaApplication>();
            services.AddTransient<IAnoLetivoApplication, AnoLetivoApplication>();
            services.AddTransient<IDiarioApplication, DiarioApplication>();
            services.AddTransient<IMateriaAgendaApplication, MateriaAgendaApplication>();

            services.AddTransient<IMovieListAplication, MovieListAplication>();
            services.AddTransient<IMovieListUsuarioAplication, MovieListUsuarioAplication>();
            services.AddTransient<IVideoMovieListAplication, VideoMovieListAplication>();
            services.AddTransient<IVideoAplication, VideoAplication>();
            services.AddTransient<IVotoVideoAplication, VotoVideoAplication>();
            services.AddTransient<IMenuApplication, MenuApplication>();
            services.AddTransient<ICategoriaVideoAplication, CategoriaVideoAplication>();

            services.AddTransient<IContaAplication, ContaAplication>();
            services.AddTransient<IPermissaoContaAplication, PermissaoContaAplication>();
            services.AddTransient<IPermissaoAplication, PermissaoAplication>();
            services.AddTransient<IUsuarioAplication, UsuarioAplication>();
            services.AddTransient<IPermissaoMenuApplication, PermissaoMenuApplication>();
            services.AddTransient<IAlunoEscolaApplication, AlunoEscolaApplication>();
            services.AddTransient<IProfessorEscolaApplication, ProfessorEscolaApplication>();
            services.AddTransient<IEscolaApplication, EscolaApplication>();

            services.AddTransient<IBimestreApplication, BimestreApplication>();
            services.AddTransient<ISerieApplication, SerieApplication>();
            services.AddTransient<ITurmaApplication, TurmaApplication>();
            services.AddTransient<IMateriaApplication, MateriaApplication>();
            services.AddTransient<IConteudoApplication, ConteudoApplication>();
            services.AddTransient<INotaApplication, NotaApplication>();
            services.AddTransient<IBoletimApplication, BoletimApplication>();
            services.AddTransient<INotaAlunoMateriaConteudoApplication, NotaAlunoMateriaConteudoApplication>();
            services.AddTransient<INotaAlunoMateriaProfessorApplication, NotaAlunoMateriaProfessorApplication>();

            services.AddTransient<ICategoriaAplication, CategoriaAplication>();
            services.AddTransient<ILogAplication<object>, LogAplication>();
            services.AddTransient<IPermissaoAplication, PermissaoAplication>();

            services.AddTransient<IAutorizacaoApiAplication, AutorizacaoApiAplication>();
            services.AddTransient<IParametroAplication, ParametroAplication>();
            return services;
        }
    }
}

