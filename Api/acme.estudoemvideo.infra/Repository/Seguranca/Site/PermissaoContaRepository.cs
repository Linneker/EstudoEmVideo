using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.Seguranca.Site;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.Seguranca.Site
{
    public class PermissaoContaRepository : RepositoryBase<PermissaoConta>, IPermissaoContaRepository
    {
        public PermissaoContaRepository(Context db) : base(db)
        {
        }

        public PermissaoConta GetPermissaoContaByData(DateTime dataCadastro)
        {
            var query = (from permissaoConta in _db.PermissoesContas
                         where permissaoConta.DataCriacao == dataCadastro
                         select permissaoConta).AsNoTracking().First();
            return query;
        }
    }
}
