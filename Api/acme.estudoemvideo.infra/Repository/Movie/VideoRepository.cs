using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Movie;
using acme.estudoemvideo.domain.Interfaces.Repository.Movie;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Movie
{
    public class VideoRepository : RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(Context db) : base(db)
        {
        }

        public List<Video> GetVideoByName(string name)
        {
            var query = (from video in _db.Videos
                         where video.Nome == name
                         select video).AsNoTracking().ToList();
            return query;
        }

        public Task<List<Video>> GetVideoByNameAsync(string name)
        {
            var query = (from video in _db.Videos
                         where video.Nome == name
                         select video).AsNoTracking().ToListAsync();
            return query;
        }

        public List<Video> GetVideoByPopularidade(EnumPopularidade enumPopularidade)
        {
            var query = (from video in _db.Videos
                         where video.EnumPopularidade == enumPopularidade
                         select video).AsNoTracking().ToList();
            return query;
        }

        public Task<List<Video>> GetVideoByPopularidadeAsync(EnumPopularidade enumPopularidade)
        {
            var query = (from video in _db.Videos
                         where video.EnumPopularidade == enumPopularidade
                         select video).AsNoTracking().ToListAsync();
            return query;
        }

        public List<Video> GetVideoByVizualizacao(long vizualizacao)
        {
            var query = (from video in _db.Videos
                         where video.Visualizacao == vizualizacao
                         select video).AsNoTracking().ToList();
            return query;
        }

        public Task<List<Video>> GetVideoByVizualizacaoAsync(long vizualizacao)
        {
            var query = (from video in _db.Videos
                         where video.Visualizacao == vizualizacao
                         select video).AsNoTracking().ToListAsync();
            return query;
        }

        public List<Video> GetVideoByVizualizacaoEmNumero(long numeroVizualizador)
        {
            var query = (from video in _db.Videos
                         where video.Visualizacao == numeroVizualizador
                         select video).AsNoTracking().ToList();
            return query;
        }

        public Task<List<Video>> GetVideoByVizualizacaoEmNumeroAsync(long numeroVizualizador)
        {
            var query = (from video in _db.Videos
                         where video.Visualizacao == numeroVizualizador
                         select video).AsNoTracking().ToListAsync();
            return query;
        }

        public List<Video> GetVideosByCategoriaId(Guid categoriaId)
        {
            var query = (from video in _db.Videos
                         join cv in _db.CategoriasVideos on video.Id equals cv.VideoId
                         where cv.CategoriaId == categoriaId
                         select video).AsNoTracking().ToList();
            return query;
        }
    }
}
