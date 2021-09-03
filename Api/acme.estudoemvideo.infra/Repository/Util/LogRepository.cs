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
    public class LogRepository : RepositoryBase<Log<object>>, ILogRepository<object>
    {
        public LogRepository(Context db) : base(db)
        {
        }

        public Task<List<Log<object>>> GetLogByDataLogAsync(DateTime dataLog)
        {
            var query = (from log in _db.Log
                         where log.DataLog == dataLog
                         select log).ToListAsync();
            return query;
        }

        public Task<List<Log<object>>> GetLogByNameAsync(string nome)
        {
            var query = (from log in _db.Log
                         where log.Nome == nome
                         select log).ToListAsync();
            return query;
        }

        public Task<List<Log<object>>> GetLogByPeriodoAsync(DateTime dataInicial, DateTime dataFinal)
        {
            var query = (from log in _db.Log
                         where log.DataLog >= dataInicial && log.DataLog <= dataFinal
                         select log).ToListAsync();
            return query;
        }
        public List<Log<object>> GetLogByDataLog(DateTime dataLog)
        {
            var query = (from log in _db.Log
                         where log.DataLog == dataLog
                         select log).ToList();
            return query;
        }

        public List<Log<object>> GetLogByName(string nome)
        {
            var query = (from log in _db.Log
                         where log.Nome == nome
                         select log).ToList();
            return query;
        }

        public List<Log<object>> GetLogByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            var query = (from log in _db.Log
                         where log.DataLog >= dataInicial && log.DataLog <= dataFinal
                         select log).ToList();
            return query;
        }
    }
}
