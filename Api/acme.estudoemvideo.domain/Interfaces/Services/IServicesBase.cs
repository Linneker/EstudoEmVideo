using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Notificacao;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Services
{
    public interface IServicesBase<TEntity> where TEntity : AbstractEntity
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);

        ValueTask<TEntity> GetByIdAsync(Guid id);
        TEntity GetById(Guid id);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Notification Commit();
        Task<int> CommitAsync();

        void Dispose();

    }
}
