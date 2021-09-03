using acme.estudoemvideo.util.ViewModel.Seguranca.Site;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel.User
{
    public class ContaViewModel : AbstractEntityViewModel
    {
        private const string URL = "/Conta", TITULO_MODAL = "CONTA", URL_DOIS = "/Conta/GetDadosTable", ID_TABLE = "tabela_conta", CAMPOS_TABELA = "";

        public ContaViewModel() : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            PermissoesContas = new HashSet<PermissaoContaViewModel>();
        }

        public ContaViewModel(string senha, string login) : base(URL, TITULO_MODAL, URL_DOIS, ID_TABLE, CAMPOS_TABELA)
        {
            _senha = SHA512(SHA384(SHA256(senha)));
            Login = login;
        }

        private string _senha;
        public bool? AlterarSenha { get; set; }
        public bool? ContaAtiva { get; set; }
        public bool Logado { get; set; }
        public string Senha
        {
            get => _senha;
            set
            {
                _senha = (SHA512(SHA384(SHA256(value))));
            }
        }
        public string Login { get; set; }
        public bool TermoDeAceite { get; set; }

        public Guid UsuarioId { get; set; }

        public virtual UsuarioViewModel Usuario { get; set; }

        public virtual ICollection<PermissaoContaViewModel> PermissoesContas { get; set; }



        protected internal static string SHA512(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA512Managed SHhash = new SHA512Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
        protected internal static string SHA256(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA256Managed SHhash = new SHA256Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
        protected internal static string SHA384(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            SHA384Managed SHhash = new SHA384Managed();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }
        protected internal static string MD5(string valor)
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] HashValue, MessageBytes = UE.GetBytes(valor);
            HMACMD5 SHhash = new HMACMD5();
            string strHex = "";
            HashValue = SHhash.ComputeHash(MessageBytes);
            foreach (byte b in HashValue)
            {
                strHex += String.Format("{0:x2}", b);
            }
            return strHex;
        }

        public override bool IsValid()
        {
            return true;
        }

    }
}
