using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces
{
    public interface IApplicationBase<TEntity> where TEntity : class
    {
        ResponseApi Add(TEntity entity, string servico);
        ResponseApi Update(TEntity entity, string servico);
        ResponseApi Delete(TEntity entity, string servico);

        ValueTask<TEntity> GetByIdAsync(Guid id);
        TEntity GetById(Guid id);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Notification Commit();
        Task<int> CommitAsync();

        void Dispose();
    }
}
