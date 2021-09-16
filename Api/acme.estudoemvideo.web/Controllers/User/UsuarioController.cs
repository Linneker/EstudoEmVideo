using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.aplication.Interfaces.School;
using acme.estudoemvideo.aplication.Interfaces.Seguranca.Site;
using acme.estudoemvideo.aplication.Interfaces.User;
using acme.estudoemvideo.aplication.Interfaces.Util;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.School;
using acme.estudoemvideo.domain.DTO.School.Util;
using acme.estudoemvideo.domain.DTO.Seguranca.Site;
using acme.estudoemvideo.domain.DTO.User;
using acme.estudoemvideo.util.ViewModel;
using acme.estudoemvideo.util.ViewModel.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acme.estudoemvideo.web.Controllers.User
{
    public class UsuarioController : LayoutBaseController<Usuario, UsuarioViewModel>
    {
        private readonly IUsuarioAplication _usuarioAplication;
        private readonly IMapper _mapper;
        private const string NOME_SERVICO = "USUARIO";
        private const string CAMINHO_SISTEMA = "/Usuario";
        private readonly IMenuApplication _menuApplication;
        private readonly IParametroAplication _parametroAplication;
        private readonly IPermissaoMenuApplication _permissaoMenuApplication;
        private readonly IAlunoEscolaApplication _alunoEscolaApplication;
        private readonly IProfessorEscolaApplication _professorEscolaApplication;
        private readonly IPermissaoAplication _permissaoAplication;
        public UsuarioController(IUsuarioAplication aplicationBase, IMenuApplication menuApplication, IMapper mapper,
            IParametroAplication parametroAplication, IAlunoEscolaApplication alunoEscolaApplication,
            IProfessorEscolaApplication professorEscolaApplication, IPermissaoAplication permissaoAplication)
            : base(aplicationBase, NOME_SERVICO, CAMINHO_SISTEMA, menuApplication, mapper)
        {
            _usuarioAplication = aplicationBase;
            _menuApplication = menuApplication;
            _parametroAplication = parametroAplication;
            _mapper = mapper;
            _alunoEscolaApplication = alunoEscolaApplication;
            _professorEscolaApplication = professorEscolaApplication;
            _permissaoAplication = permissaoAplication;
        }

        //public override IActionResult Index()
        //{
        //    return View(new List<UsuarioViewModel>());
        //}

        public RespostaPadraoModels Cadastrar(string json, string escolaId, string materiaId)
        {
            RespostaPadraoModels respostaPadraoModels = new RespostaPadraoModels();
            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(json);

            Permissao objPermissao = _permissaoAplication.GetById(usuario.Contas.Select(t => t).Select(t => t.PermissoesContas.FirstOrDefault().PermissaoId).FirstOrDefault());
            if (objPermissao is null)
            {
                respostaPadraoModels.Codigo = EnumHttp.BAD_REQUEST;
                respostaPadraoModels.Descricao = "Permissaõ Invalida!";
                respostaPadraoModels.Mensagem = "Permissão foi modificada, permissão invalida!";
                respostaPadraoModels.Status = EnumLog.ERROR.ToString();
                this.Response.StatusCode = (int)EnumHttp.BAD_REQUEST;
                return respostaPadraoModels;
            }
            string permissao = objPermissao.Nome;
            if (permissao.Equals("Aluno"))
            {
                AlunoEscola alunoEscola = new AlunoEscola();
                alunoEscola.EscolaId = Guid.Parse(escolaId);
                alunoEscola.Usuario = usuario;
                respostaPadraoModels = _mapper.Map<RespostaPadraoModels>(_alunoEscolaApplication.Add(alunoEscola, "ALUNO"));
            }
            else if (permissao.Equals("Professor"))
            {
                var idsEscola = escolaId.Split(",");
                foreach (var idEscola in idsEscola)
                {
                    ProfessorEscola professorEscola = new ProfessorEscola();
                    professorEscola.EscolaId = Guid.Parse(idEscola);
                    professorEscola.PopularidadeProfessor = 5;
                    var idsMaterias = materiaId.Split(",");
                    foreach (var idMateria in idsMaterias)
                    {
                        if (professorEscola.MateriasProfessores.Any(t => t.MateriaId.ToString().Equals(idMateria)))
                            continue;

                        MateriaProfessorEscola materiaProfessorEscola = new MateriaProfessorEscola();
                        materiaProfessorEscola.MateriaId = Guid.Parse(idMateria);
                        professorEscola.MateriasProfessores.Add(materiaProfessorEscola);
                    }
                    usuario.ProfessorEscolas.Add(professorEscola);
                }
                respostaPadraoModels = _mapper.Map<RespostaPadraoModels>(_usuarioAplication.Add(usuario, "PROFESSOR"));
            }
            else
            {
                respostaPadraoModels = _mapper.Map<RespostaPadraoModels>(_usuarioAplication.Add(usuario, NOME_SERVICO));
            }

            return respostaPadraoModels;
        }
    }
}
