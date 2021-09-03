using acme.estudoemvideo.domain.DTO.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Interfaces.Util
{
    public interface ILogAplication<TEntity> : IApplicationBase<Log<TEntity>> where TEntity : class
    {
        List<Log<TEntity>> GetLogByName(string nome);
        List<Log<TEntity>> GetLogByDataLog(DateTime dataLog);
        List<Log<TEntity>> GetLogByPeriodo(DateTime dataInicial, DateTime dataFinal);

        Task<List<Log<TEntity>>> GetLogByNameAsync(string nome);
        Task<List<Log<TEntity>>> GetLogByDataLogAsync(DateTime dataLog);
        Task<List<Log<TEntity>>> GetLogByPeriodoAsync(DateTime dataInicial, DateTime dataFinal);
        
    }
}
