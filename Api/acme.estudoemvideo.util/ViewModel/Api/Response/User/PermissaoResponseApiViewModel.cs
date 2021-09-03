using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.util.ViewModel.Api.Response.User
{
    public class PermissaoResponseApiViewModel
    {
        public PermissaoResponseApiViewModel(string nome, int nivel)
        {
            Nome = nome;
            Nivel = nivel;
        }

        public PermissaoResponseApiViewModel(string nome, int nivel, bool? delete, bool? update, bool? add, bool? read) : this(nome, nivel)
        {
            Delete = delete;
            Update = update;
            Add = add;
            Read = read;
        }

        public string Nome { get; private set; }
        public int Nivel { get; private set; }

        public bool? Delete { get; set; }
        public bool? Update { get; set; }
        public bool? Add { get; set; }
        public bool? Read { get; set; }
    }
}
