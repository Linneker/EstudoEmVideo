using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.Interfaces.Repository.School;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.School
{
    public class EscolaRepository : RepositoryBase<Escola>, IEscolaRepository
    {
        public EscolaRepository(Context db) : base(db)
        {
        }

        public Escola GetEscolaByCnpj(string cnpj)
        {
            var query = (from escola in _db.Escolas
                         where escola.Cnpj == cnpj
                         select escola).AsNoTracking().First<Escola>();
            return query;
        }
        public List<Escola> GetEscolasByNome(string nome)
        {
            var query = (from escola in _db.Escolas
                         where escola.Nome == nome
                         select escola).AsNoTracking().ToList<Escola>();
            return query;
        }

        public List<Escola> GetEscolasByRazaoSocial(string razaoSocial)
        {
            var query = (from escola in _db.Escolas
                         where escola.Nome == razaoSocial
                         select escola).AsNoTracking().ToList<Escola>();
            return query;
        }
        public Task<List<Escola>> GetEscolasByNomeAsync(string nome)
        {
            var query = (from escola in _db.Escolas
                         where escola.Nome == nome
                         select escola).AsNoTracking().ToListAsync<Escola>();
            return query;
        }

        public Task<List<Escola>> GetEscolasByRazaoSocialAsync(string razaoSocial)
        {
            var query = (from escola in _db.Escolas
                         where escola.Nome == razaoSocial
                         select escola).AsNoTracking().ToListAsync<Escola>();
            return query;
        }

    }
}
