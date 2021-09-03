using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.domain.Interfaces.Repository.User;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository.User
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context db) : base(db)
        {
        }

        public Usuario GetUsuarioByCpf(string cpf)
        {
            var query = (from user in _db.Usuarios
                         where user.Cpf == cpf
                         select user).AsNoTracking().First<Usuario>();
            return query;
        }
        public List<Usuario> GetUsuarioByDataNascimento(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            var query = (from user in _db.Usuarios
                         where user.DataDeNascimento >= dataNascimentoInicial && user.DataDeNascimento <= dataNascimentoFinal
                         select user).AsNoTracking().ToList<Usuario>();
            return query;
        }
        public Task<List<Usuario>> GetUsuarioByDataNascimentoAsync(DateTime dataNascimentoInicial, DateTime dataNascimentoFinal)
        {
            var query = (from user in _db.Usuarios
                         where user.DataDeNascimento >= dataNascimentoInicial && user.DataDeNascimento <= dataNascimentoFinal
                         select user).AsNoTracking().ToListAsync<Usuario>();
            return query;
        }

        public Usuario GetUsuarioByEmail(string email)
        {
            var query = (from user in _db.Usuarios
                         where user.Email == email
                         select user).AsNoTracking().FirstOrDefault<Usuario>();
            return query;

        }

        public Usuario GetUsuarioByTelefone(string telefone)
        {
            var query = (from user in _db.Usuarios
                         where user.Telefone == telefone
                         select user).AsNoTracking().FirstOrDefault<Usuario>();
            return query;
        }

        public List<Usuario> GetUsuarioByPermissao(string nomePermissao)
        {
            var query = (from user in _db.Usuarios
                         join c in _db.Contas on user.Id equals c.UsuarioId
                         join pc in _db.PermissoesContas on c.Id equals pc.ContaId
                         join p in _db.Permissoes on pc.PermissaoId equals p.Id
                         where p.Nome.Equals(nomePermissao)
                         select user).Include(t=>t.Contas)
                         .ThenInclude(t=>t.PermissoesContas)
                         .ThenInclude(T=>T.Permissao)
                         .Include(t=>t.ProfessorEscolas)
                         .Include(t=>t.AlunosEscolas)
                         .AsNoTracking().ToList();
            return query;
        }

        public Task<List<Usuario>> GetUsuarioByPermissaoAsync(string nomePermissao)
        {
            var query = (from user in _db.Usuarios
                         join c in _db.Contas on user.Id equals c.UsuarioId
                         join pc in _db.PermissoesContas on c.Id equals pc.ContaId
                         join p in _db.Permissoes on pc.PermissaoId equals p.Id
                         where p.Nome.Equals(nomePermissao)
                         select user).Include(t => t.Contas).AsNoTracking().ToListAsync();
            return query;
        }
    }
}
