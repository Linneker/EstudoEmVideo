using acme.estudoemvideo.domain.DTO.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace acme.estudoemvideo.util.ViewModel
{
   [NotMapped]
   public  class AbstractEntityViewModel : NotificationBaseViewModel
    {
        private string _url, _tituloModal, _urlDois, _idTable;
        private List<string> _camposTabela;
        private string valor_botao;
        public AbstractEntityViewModel(string url, string tituloModal, string urlDois, string idTable, List<string> camposTabela)
        {
            _url = url;
            _tituloModal = tituloModal;
            _urlDois = urlDois;
            _idTable = idTable;
            _camposTabela = camposTabela;
        }
        public AbstractEntityViewModel(string url, string tituloModal, string urlDois, string idTable,  string camposTabela)
        {
            _url = url;
            _tituloModal = tituloModal;
            _urlDois = urlDois;
            _idTable = idTable;
        }
        public Guid Id { get; set; }
        [Display(Name = "Criação")]
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataModificacao { get; set; }
        public DateTime? DataInativacao { get; set; }

        public EnumStatus Status { get; set; }
        [Display(Name = "Opções")]
        [NotMapped]
        public virtual string BotaoEditarDeletarVizualizar {
            get
            {
                if (_camposTabela != null)
                {
                    _camposTabela.Add("{ data: 'botaoEditarDeletarVizualizar' }");
                }
                else
                    _camposTabela = new List<string>();

                string botoes = $"<a class='btn btn-danger' onclick=\"deletar_padrao('{Id}','{_url}/Delete','{_tituloModal}','{_urlDois}','{_idTable}',{JsonConvert.SerializeObject(_camposTabela).Replace("\"","")})\">Remover</a> ";
                botoes += $"<a class='btn btn-warning' onclick=\"open_modal('Modal/ModalEditar{_tituloModal}?Id={Id}','GET','{_tituloModal}','','')\">Editar</a>";
                return botoes;
            }
            set => valor_botao = value;

        }
        [Display(Name = "Opções")]
        [NotMapped]
        public virtual string BotaoEditarEDeletar { get; set; }
        [Display(Name = "Opção")]
        [NotMapped]
        public virtual string BotaoEditar { get; set; }
        [Display(Name = "Opção")]
        [NotMapped]
        public virtual string BotaoDeletar { get; set; }
        [Display(Name = "Opção")]
        [NotMapped]
        public string BotaoVizualizar { get; set; }
    }
}
