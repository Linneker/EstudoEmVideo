using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.User
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
        public ContaRepository(Context db) : base(db)
        {
        }

        public Conta Login(Conta conta)
        {
            var query = (from perm in _db.Permissoes
                         join perConta in _db.PermissoesContas on perm.Id equals perConta.PermissaoId
                         join cnt in _db.Contas on perConta.ContaId equals cnt.Id
                         join u in _db.Usuarios on cnt.UsuarioId equals u.Id
                         where cnt.Login == conta.Login && cnt.Senha == conta.Senha
                         select new { cnt, perm, u, perConta }).AsNoTracking().FirstOrDefault();
            if (query is null)
            {
                return null;
            }
            query.cnt.Usuario = query.u;
            query.cnt.Usuario.Contas = new HashSet<Conta>();
            query.perConta.Conta = new Conta();
            query.perm.PermissoesContas = new HashSet<PermissaoConta>();
            query.perConta.Permissao = query.perm;
            query.cnt.PermissoesContas.Add(query.perConta);
            return query.cnt;
        }
    }
}
