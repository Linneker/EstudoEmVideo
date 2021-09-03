using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.infra.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.infra.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : AbstractEntity
    {
        protected internal readonly DbContextOptionsBuilder<Context> _dbDois = new DbContextOptionsBuilder<Context>();
        protected internal Context _db;

        public RepositoryBase(Context db)
        {
            _db = db;
        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                _db.Add(entity);
            }
            catch (Exception e)
            {
                entity.AddNotification($"{(int)EnumCodigoMensagem.ERRO_ADD}", $"Mensagem: {e.Message}, InnerException: {e.InnerException}");
            }
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            try
            {

                using (var db = new Context(_dbDois.Options))
                {
                    _dbDois.EnableSensitiveDataLogging(true);
                    _dbDois.EnableDetailedErrors(true);
                    db.Set<TEntity>().Update(entity);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                entity.AddNotification($"{(int)EnumCodigoMensagem.ERRO_UPDATE}", $"Mensagem: {e.Message}, InnerException: {e.InnerException}");
            }
            return entity;
        }
        public TEntity Delete(TEntity entity)
        {
            try
            {
                _db.Entry(entity).State = EntityState.Deleted;
            }
            catch (Exception e)
            {
                entity.AddNotification($"{(int)EnumCodigoMensagem.ERRO_DELETE }", $"Mensagem: {e.Message}, InnerException: {e.InnerException}");
            }
            return entity;
        }


        public ValueTask<TEntity> GetByIdAsync(Guid id)
        {
            var elemento = _db.Set<TEntity>().FindAsync(id);
            return elemento;

        }

        public TEntity GetById(Guid id)
        {
            var elemento = _db.Set<TEntity>().Find(id);
            return elemento;
        }
        public List<TEntity> GetAll()
        {
            var elemento = _db.Set<TEntity>().AsNoTracking().ToList();
            return elemento;
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            var elemento = _db.Set<TEntity>().AsNoTracking().ToListAsync();
            return elemento;
        }
        public void Dispose() => GC.SuppressFinalize(this);

        public Task<int> CommitAsync()
        {
            return _db.SaveChangesAsync();
        }
        public Notification Commit()
        {
            Notification notification;
            try
            {
                bool salvo = _db.SaveChanges() > 0;
                notification = new Notification($"{(int)EnumCodigoMensagem.SUCESSO}", "SALVO COM SUCESSO!");
            }
            catch (Exception e)
            {
                notification = new Notification($"{(int)EnumCodigoMensagem.ERRO_COMMIT}", $"Mensagem: {e.Message}, InnerException: {e.InnerException}");
            }
            return notification;
        }
    }
}
