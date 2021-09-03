using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.util.ViewModel.School;
using acme.estudoemvideo.util.ViewModel.Util;
using acme.estudoemvideo.web.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School
{
    public class AlunoEscolaController : LayoutBaseController<AlunoEscola, AlunoEscolaViewModel>
    {
        private readonly IAlunoEscolaApplication _alunoEscolaApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "ALUNO ESCOLA";
        private const string CAMINHO = "/AlunoEscola";
        private readonly IMenuApplication _menuApplication;

        public AlunoEscolaController(IAlunoEscolaApplication alunoEscolaApplication, IMapper mapper, IMenuApplication menuApplication) : base(alunoEscolaApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _alunoEscolaApplication = alunoEscolaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
        }
        //[Authorize]
        //public override IActionResult Index()
        //{
        //    var menus = _menuApplication.GetMenusByCaminho(CAMINHO + "/Index");
        //    var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
        //    ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
        //    ViewBag.Login = permissao.Conta.Login;
        //    ViewData["Permissao"] = permissao;
        //    return View(permissao.Url, new List<AlunoEscolaViewModel>());
        //}
        //[Authorize]
        //[HttpGet]
        //public override DataTableResponseViewModel<AlunoEscolaViewModel> GetDadosTable() { 

        //}

        //[Authorize]
        //[HttpGet]
        //public List<AlunoEscolaViewModel> GetAlunosEscolaByEscolaId(Guid escolaId) =>_mapper.Map<List<AlunoEscolaViewModel>>(_alunoEscolaApplication.GetAlunosEscolaByEscolaId(escolaId));

        [Authorize]
        [HttpGet]
        public Task<List<AlunoEscola>> GetAlunosEscolaByEscolaIdAsync(Guid escolaId) => _alunoEscolaApplication.GetAlunosEscolaByEscolaIdAsync(escolaId);
            

    }
}
