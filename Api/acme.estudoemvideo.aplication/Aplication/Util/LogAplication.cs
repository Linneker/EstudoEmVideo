using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Services.Util;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication.Util
{
    public class LogAplication : ApplicationBase<Log<object>>, ILogAplication<object>
    {
        private readonly ILogServices<object> _logRepository;
        public LogAplication(ILogServices<object> logRepository) : base(logRepository)
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
