using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Util
{
    public class ParametroRepository : RepositoryBase<Parametro>, IParametroRepository
    {
        public ParametroRepository(Context db) : base(db)
        {
        }

        public List<Parametro> GetParametrosByAtivo(bool ativo)
        {
            var query = (from param in _db.Parametros
                         where param.Status == (ativo ? EnumStatus.Ativo : EnumStatus.Inativo)
                         select param).AsNoTracking().ToList();
            return query;
        }

        public List<Parametro> GetParametrosByNome(string nome)
        {
            var query = (from param in _db.Parametros
                         where param.Nome == nome
                         select param).AsNoTracking().ToList();
            return query;
        }
        public Task<List<Parametro>> GetParametrosByAtivoAsync(bool ativo)
        {
            var query = (from param in _db.Parametros
                         where param.Status == (ativo ? EnumStatus.Ativo : EnumStatus.Inativo)
                         select param).AsNoTracking().ToListAsync();
            return query;
        }

        public Task<List<Parametro>> GetParametrosByNomeAsync(string nome)
        {
            var query = (from param in _db.Parametros
                         where param.Nome == nome
                         select param).AsNoTracking().ToListAsync();
            return query;
        }
    }
}
