using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Interfaces.Repository.Util
{
    public interface ILogRepository<TEntity> : IRepositoryBase<Log<TEntity>> where TEntity : class
    {
        List<Log<TEntity>> GetLogByPeriodo(DateTime dataInicial, DateTime dataFinal);
        List<Log<TEntity>> GetLogByName(string nome);
        List<Log<TEntity>> GetLogByDataLog(DateTime dataLog);

        Task<List<Log<TEntity>>> GetLogByPeriodoAsync(DateTime dataInicial, DateTime dataFinal);
        Task<List<Log<TEntity>>> GetLogByNameAsync(string nome);
        Task<List<Log<TEntity>>> GetLogByDataLogAsync(DateTime dataLog);
    }
}
