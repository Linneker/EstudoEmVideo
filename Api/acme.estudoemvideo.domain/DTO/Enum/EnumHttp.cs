using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.domain.DTO.Enum
{
    public enum EnumHttp
    {
        SUCESSO = 200,
        ERRO_SERVIDOR = 500,
        SEM_PERMISSAO = 403,
        INFORMACOES_ERRADAS = 402,
        BAD_REQUEST = 400
    }
}
