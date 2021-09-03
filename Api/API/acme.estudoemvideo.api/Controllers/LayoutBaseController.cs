using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.util.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace acme.estudoemvideo.api.Controllers
{
    [Produces("application/json")]
    [Route("EstudoEmVideo/[controller]")]
    [ApiController]
    public class LayoutBaseController<TEntity, TEntityViewModel> : ControllerBase where TEntity : AbstractEntity where TEntityViewModel : AbstractEntityViewModel
    {
        private readonly IApplicationBase<TEntity> _aplication;
        //private readonly 
        private readonly string _nomeMetodo;
        //private readonly ILogAbstractApplication
        private readonly IMapper _mapper;
        public LayoutBaseController(IApplicationBase<TEntity> aplicationBase, IMapper mapper, string nomeMetodo)
        {
            _aplication = aplicationBase;
            _nomeMetodo = nomeMetodo;
            _mapper = mapper;
        }

        [Authorize("Bearer")]
        [HttpPost]
        public RespostaPadraoModels Post([FromBody]TEntity tEntity) => _mapper.Map<RespostaPadraoModels>(_aplication.Add(tEntity, _nomeMetodo)); 
        
        [Authorize("Bearer")]
        [HttpPut]
        public RespostaPadraoModels Put([FromBody]TEntity tEntity) => _mapper.Map<RespostaPadraoModels>(_aplication.Update(tEntity, _nomeMetodo));
        
            
        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public RespostaPadraoModels Delete(Guid id)=>_mapper.Map<RespostaPadraoModels>(_aplication.Delete(_aplication.GetById(id), _nomeMetodo));
        

        [Authorize("Bearer")]
        [HttpGet("{id}")]
        public TEntityViewModel GetById(Guid id)=>  _mapper.Map<TEntityViewModel>(_aplication.GetById(id));
            
        

        [Authorize("Bearer")]
        [HttpGet]
        public List<TEntityViewModel> GetAll()=>_mapper.Map<List<TEntityViewModel>>(_aplication.GetAll());
        



     
    }
}