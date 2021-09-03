using acme.estudoemvideo.domain.DTO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Log
{
    public class AbstractLog : AbstractEntity
    {
        public string Mensagem { get; set; }
        public string DadoRecebido{ get; set; }
        public string DadoRetornado { get; set; }
        public EnumLog StatusLog { get; set; }
        public string LoginUsuario { get; set; }
        public string NomeUsuario { get; set; }

    }
}
