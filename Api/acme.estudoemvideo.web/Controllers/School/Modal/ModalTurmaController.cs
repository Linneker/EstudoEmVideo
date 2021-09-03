using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.School.Matter;
using acme.estudoemvideo.aplication.Interfaces.School.Util;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel.School;
using acme.estudoemvideo.util.ViewModel.Util;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.School.Modal
{
    public class ModalTurmaController : LayoutBaseController<Turma,TurmaViewModel>
    {
        private readonly ITurmaApplication _turmaApplication;
        private readonly IMapper _mapper;
        private const string NOME_METODO = "TURMA";
        private const string CAMINHO = "/Turma";
        private readonly IMenuApplication _menuApplication;
        private readonly IEscolaApplication _escolaApplication;
        private readonly ISerieApplication _serieApplication;
        private readonly IBimestreApplication _bimestreApplication;
        private readonly IUsuarioAplication _usuarioApplication;
        private readonly IMateriaApplication _materiaApplication;
        public ModalTurmaController(ITurmaApplication turmaApplication, IMapper mapper, IMenuApplication menuApplication, 
            IEscolaApplication escolaApplication, ISerieApplication serieApplication, IBimestreApplication bimestreApplication,
            IUsuarioAplication usuarioApplication, IMateriaApplication materiaApplication)
            : base(turmaApplication, NOME_METODO, CAMINHO, menuApplication, mapper)
        {
            _turmaApplication = turmaApplication;
            _mapper = mapper;
            _menuApplication = menuApplication;
            _escolaApplication = escolaApplication;
            _serieApplication = serieApplication;
            _bimestreApplication = bimestreApplication;
            _usuarioApplication = usuarioApplication;
            _materiaApplication = materiaApplication;
        }

        [Route("Turma/Modal/ModalCadastroTurma")]
        [Authorize]
        public IActionResult ModalCadastroTurma()
        {
            var menus = _menuApplication.GetMenusByCaminho("/Modal/ModalCadastroTurma");
            var permissao = Permissao(menus == null ? new List<MenuViewModel>() : _mapper.Map<List<MenuViewModel>>(menus));
            ViewBag.NomeUsuario = permissao.Conta.Usuario.Nome;
            ViewBag.Login = permissao.Conta.Login;
            ViewData["Permissao"] = permissao;

            if (permissao is null || (permissao.Add.HasValue && !permissao.Add.Value))
            {
                return View(permissao.Url);
            }
            ViewBag.Series = _serieApplication.GetAll().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome
            });
            ViewBag.Bimestres = _bimestreApplication.GetAll().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome
            });
            var listSelectEscola =_escolaApplication.GetAll().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome
            }).ToList();
            listSelectEscola.Add(new SelectListItem {
                Value = "",
                Text = "",
                Selected = true
            });
            ViewBag.Escolas = listSelectEscola;
            ViewBag.Materias = _materiaApplication.GetAll().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nome
            });
            //TODO: DEVE MUDAR PARA PEGAR O PROFESSOR E ALUNO DE ACORDO COM A ESCOLA SELECIONADA PARA CADASTRAR A TURMA
            //List<Usuario> professores = _usuarioApplication.GetUsuarioByPermissao("Professor");
            //List<Usuario> alunos = _usuarioApplication.GetUsuarioByPermissao("Aluno");

            //ViewBag.Professores= professores.Select(x => new SelectListItem
            //{
            //    Value = x.ProfessorEscolas.Where(t=>t.UsuarioId.Equals(x.Id)).FirstOrDefault().Id.ToString(),
            //    Text = x.Nome
            //});
            //ViewBag.Alunos= alunos.Select(x => new SelectListItem
            //{
            //    Value = x.AlunosEscolas.Where(t => t.UsuarioId.Equals(x.Id)).FirstOrDefault().Id.ToString(),
            //    Text = x.Nome
            //});
            TurmaViewModel turmaViewModel = new TurmaViewModel();
            return View((permissao.Url is null ? "../Turma/Modal/ModalCadastroTurma" : permissao.Url), turmaViewModel);
        }
    }
}
