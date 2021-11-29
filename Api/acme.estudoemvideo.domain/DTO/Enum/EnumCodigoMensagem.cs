using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Enum
{
    public enum EnumCodigoMensagem
    {
        NOERRO = 0,
        LOGIN_OU_SENHA_INVALIDO = 1,
        CONTA_LOGADA = 2,
        ERRO_COMMIT = 3,
        ERRO_ADD=4,
        ERRO_DELETE = 5,
        ERRO_UPDATE = 6,
        NULL = 50,
        MAXLENGTH = 100,
        MINLENGTH = 150,
        INFORMACAO_INVALIDA = 500,
        SUCESSO = 200
    }
}
