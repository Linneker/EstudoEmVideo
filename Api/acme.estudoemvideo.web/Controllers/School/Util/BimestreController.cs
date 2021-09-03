using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.util.ViewModel.School.Util;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Util
{
    public class BimestreController : LayoutBaseController<Bimestre,BimestreViewModel>
    {
        private readonly IBimestreApplication _bimestreApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "BIMESTRE";
        private const string CAMINHO = "/Bimestre";
        private readonly IMenuApplication _menuApplication;

        public BimestreController(IBimestreApplication bimestreApplication, IMapper mapper, IMenuApplication menuApplication)
            :base(bimestreApplication,NOME_METODO,CAMINHO,menuApplication,mapper)
        {
            _bimestreApplication = bimestreApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }
        [Authorize]
        public override IActionResult Index()
        {
            try
            {
                var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/Index");
                var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
                ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
                ViewBag.Login = permissao.Conta.Login;
                ViewData["Permissao"] = permissao;
                var t = _mapper.Map<List<BimestreViewModel>>(GetAll());
                if (t is null)
                {
                    return Index1();
                }
                return View(permissao.Url, t);
            }
            catch (Exception e)
            {
                return Index1();
            }
        }

    }
}
