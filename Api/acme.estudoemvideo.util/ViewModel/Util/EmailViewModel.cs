using System;
using System.Collections.Generic;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.Util
{
    public class EmailViewModel
    {
        public EmailViewModel(int numeroDeAnexo)
        {
            Anexo = new string[numeroDeAnexo];
        }

        public string EmailEnvio { get; set; }
        public string SenhaEnvio { get; set; }

        public string EmailEnviador { get; set; }
        public string NomeEnviador { get; set; }
        public string EmailDestino { get; set; }

        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string[] Anexo { get; set; }

        public string ConfigSet { get; set; }
        public string Host { get; set; }
        public int Porta { get; set; }

        public bool Ssl { get; set; }
        public bool TextHtml { get; set; }
    }
}
