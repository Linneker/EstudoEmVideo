using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.Interfaces.Repository;
using acme.estudoemvideo.domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services
{
    public class ServiceBase<TEntity> : IServicesBase<TEntity> where TEntity : AbstractEntity
    {
        protected internal readonly IRepositoryBase<TEntity> _repositoryBase;
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public TEntity Add(TEntity entity)
        {
            if (entity.IsValid())
            {
                return _repositoryBase.Add(entity);
            }
            else
            {
                return entity;
            }
        }
        public TEntity Update(TEntity entity)
        {
            if (entity.IsValid())
            {
                return _repositoryBase.Update(entity);
            }
            else
            {
                return entity;
            }
        }

        public TEntity Delete(TEntity entity)
        {
            if (entity.IsValid())
            {
                return _repositoryBase.Delete(entity);
            }
            else
            {
                return entity;
            }
        }

        public List<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public Task<List<TEntity>> GetAllAsync()
        {
            return _repositoryBase.GetAllAsync();
        }

        public TEntity GetById(Guid id)
        {
            return _repositoryBase.GetById(id);
        }

        public ValueTask<TEntity> GetByIdAsync(Guid id)
        {
            return _repositoryBase.GetByIdAsync(id);
        }
        public Notification Commit()
        {
            return _repositoryBase.Commit();
        }
        public Task<int> CommitAsync()
        {
            return _repositoryBase.CommitAsync();
        }
        public void Dispose()
        {
            _repositoryBase.Dispose();
        }
    }
}
