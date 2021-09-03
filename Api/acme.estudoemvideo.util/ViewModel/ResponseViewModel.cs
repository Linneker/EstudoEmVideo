using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel
{
    public class ResponseViewModel
    {
        public ResponseViewModel() { }
        public ResponseViewModel(bool erro, string titulo, string msg)
        {
            Erro = erro;
            Titulo = titulo;
            Msg = msg;
        }
        public EnumHttp EnumHttp { get; set; }
        public List<Notification> Notifications { get; set; }
        public bool Erro { get; set; }
        public string Titulo { get; set; }
        public string Msg { get; set; }
    }
}
