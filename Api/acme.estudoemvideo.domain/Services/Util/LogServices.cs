using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Repository.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.domain.Services.Util
{
    public class LogServices : ServiceBase<Log<object>>, ILogServices<object>
    {
        private readonly ILogRepository<object> _logRepository;
        public LogServices(ILogRepository<object> logRepository) : base(logRepository)
        {
            _logRepository = logRepository;
        }
        public List<Log<object>> GetLogByDataLog(DateTime dataLog)
        {
            return _logRepository.GetLogByDataLog(dataLog);
        }

        public List<Log<object>> GetLogByName(string nome)
        {
            return _logRepository.GetLogByName(nome);
        }

        public List<Log<object>> GetLogByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            return _logRepository.GetLogByPeriodo(dataInicial, dataFinal);
        }

        public Task<List<Log<object>>> GetLogByDataLogAsync(DateTime dataLog)
        {
            return _logRepository.GetLogByDataLogAsync(dataLog);
        }

        public Task<List<Log<object>>> GetLogByNameAsync(string nome)
        {
            return _logRepository.GetLogByNameAsync(nome);
        }

        public Task<List<Log<object>>> GetLogByPeriodoAsync(DateTime dataInicial, DateTime dataFinal)
        {
            return _logRepository.GetLogByPeriodoAsync(dataInicial, dataFinal);
        }
    }
}
