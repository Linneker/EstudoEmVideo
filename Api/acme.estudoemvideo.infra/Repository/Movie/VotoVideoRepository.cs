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
    public class VotoVideoRepository : RepositoryBase<VotoVideo>, IVotoVideoRepository
    {
        public VotoVideoRepository(Context db) : base(db)
        {
        }

        public List<VotoVideo> GetVotoVideoByLikeRelevancia(Guid idVideo, long likeRelevancia)
        {
            var query = (from vtVideo in _db.VotosVideos
                         where vtVideo.LikeRelevancia == likeRelevancia
                         && vtVideo.VideoId == idVideo
                         select vtVideo).AsNoTracking().ToList();
            return query;
        }

        public Task<List<VotoVideo>> GetVotoVideoByLikeRelevanciaAsync(Guid idVideo, long likeRelevancia)
        {
            var query = (from vtVideo in _db.VotosVideos
                         where vtVideo.LikeRelevancia == likeRelevancia
                         && vtVideo.VideoId == idVideo
                         select vtVideo).AsNoTracking().ToListAsync();
            return query;
        }

        public List<VotoVideo> GetVotoVideoByObservacao(Guid idVideo, string observacao)
        {
            var query = (from vtVideo in _db.VotosVideos
                         where vtVideo.Observacao == observacao
                         && vtVideo.VideoId == idVideo
                         select vtVideo).AsNoTracking().ToList();
            return query;
        }

        public Task<List<VotoVideo>> GetVotoVideoByObservacaoAsync(Guid idVideo, string observacao)
        {
            var query = (from vtVideo in _db.VotosVideos
                         where vtVideo.Observacao == observacao
                         && vtVideo.VideoId == idVideo
                         select vtVideo).AsNoTracking().ToListAsync();
            return query;
        }
    }
}
