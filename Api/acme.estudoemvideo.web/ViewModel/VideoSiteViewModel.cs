using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.ViewModel
{
    public class VideoSiteViewModel
    {
        public VideoSiteViewModel()
        {
        }

        public VideoSiteViewModel(string nome, string descricao, List<SelectListItem> cetogia)
        {
            Nome = nome;
            Descricao = descricao;
            Cetogia = cetogia;
        }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Categoia")]
        public IEnumerable<SelectListItem> Cetogia { get; set; }
    }
}
