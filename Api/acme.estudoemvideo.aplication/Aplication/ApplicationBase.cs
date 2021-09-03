using acme.estudoemvideo.aplication.Interfaces;
using acme.estudoemvideo.domain.DTO;
using acme.estudoemvideo.domain.DTO.Enum;
using acme.estudoemvideo.domain.DTO.Notificacao;
using acme.estudoemvideo.domain.DTO.Util;
using acme.estudoemvideo.domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acme.estudoemvideo.aplication.Aplication
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> where TEntity : AbstractEntity
    {
        protected internal readonly IServicesBase<TEntity> _repositoryBase;
        public ApplicationBase(IServicesBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public ResponseApi Add(TEntity entity, string servico)
        {
            ResponseApi responseApi = new ResponseApi();
            _repositoryBase.Add(entity);
            if (entity.HasNotifications)
            {
                responseApi.Mensagem = $"PROBLEMA AO CADASTRADAR {servico}!";
                responseApi.Codigo = EnumHttp.INFORMACOES_ERRADAS;
                responseApi.Descricao = $"{servico} COM PROBLEMA AO REALIZAR O CADASTRO!";
                responseApi.Status = EnumHttp.SUCESSO.ToString();
                responseApi.Notifications = entity.Notifications.ToList();
            }
            else
            {
                Notification notificacao = Commit();
                if (notificacao.Key == ((int)EnumCodigoMensagem.SUCESSO).ToString())
                {
                    responseApi.Mensagem = $"{servico} CADASTRADO COM SUCESSO!";
                    responseApi.Codigo = EnumHttp.SUCESSO;
                    responseApi.Descricao = $"{servico} CADASTRADO SEM NENHUM PROBLEMA!";
                    responseApi.Status = EnumHttp.SUCESSO.ToString();
                    responseApi.Notifications = entity.Notifications.ToList();

                }
                else
                {
                    responseApi.Mensagem = $"PROBLEMA AO CADASTRAR {servico}!";
                    responseApi.Codigo = EnumHttp.ERRO_SERVIDOR;
                    responseApi.Descricao = $"{servico} COM PROBLEMA AO REALIZAR O CADASTRO!";
                    responseApi.Status = EnumHttp.ERRO_SERVIDOR.ToString();
                    responseApi.Notifications = new List<Notification>();
                    responseApi.Notifications.Add(notificacao);
                }
            }
            return responseApi;
        }

        public ResponseApi Update(TEntity entity,string servico)
        {
            ResponseApi responseApi = new ResponseApi();
            _repositoryBase.Update(entity);
            if (entity.HasNotifications)
            {
                responseApi.Mensagem = $"PROBLEMA AO ATUALIZAR {servico}!";
                responseApi.Codigo = EnumHttp.INFORMACOES_ERRADAS;
                responseApi.Descricao = $"{servico} COM PROBLEMA AO REALIZAR O ATUALIZAÇÃO!";
                responseApi.Status = EnumHttp.SUCESSO.ToString();
                responseApi.Notifications = entity.Notifications.ToList();
            }
            else
            {
                Notification notificacao = Commit();
                if (notificacao.Key == ((int)EnumCodigoMensagem.SUCESSO).ToString())
                {
                    responseApi.Mensagem = $"{servico} ATUALIZADO COM SUCESSO!";
                    responseApi.Codigo = EnumHttp.SUCESSO;
                    responseApi.Descricao = $"{servico} ATUALIZADO SEM NENHUM PROBLEMA!";
                    responseApi.Status = EnumHttp.SUCESSO.ToString();
                    responseApi.Notifications = entity.Notifications.ToList();

                }
                else
                {
                    responseApi.Mensagem = $"PROBLEMA AO ATUALIZAR {servico}!";
                    responseApi.Codigo = EnumHttp.ERRO_SERVIDOR;
                    responseApi.Descricao = $"{servico} COM PROBLEMA AO REALIZAR O ATUALIZAÇÃO!";
                    responseApi.Status = EnumHttp.SUCESSO.ToString();
                    responseApi.Notifications = new List<Notification>();
                    responseApi.Notifications.Add(notificacao);
                }
            }
            return responseApi;
        }

        public ResponseApi Delete(TEntity entity, string servico)
        {
            ResponseApi responseApi = new ResponseApi();
            _repositoryBase.Delete(entity);
            if (entity.HasNotifications)
            {
                responseApi.Mensagem = $"PROBLEMA AO REMOVER {servico}!";
                responseApi.Codigo = EnumHttp.INFORMACOES_ERRADAS;
                responseApi.Descricao = $"{servico} COM PROBLEMA AO REALIZAR A REMOÇÃO!";
                responseApi.Status = EnumHttp.SUCESSO.ToString();
                responseApi.Notifications = entity.Notifications.ToList();
            }
            else
            {
                Notification notificacao = Commit();
                if (notificacao.Key == ((int)EnumCodigoMensagem.SUCESSO).ToString())
                {
                    responseApi.Mensagem = $"{servico} REMOVIDO COM SUCESSO!";
                    responseApi.Codigo = EnumHttp.SUCESSO;
                    responseApi.Descricao = $"{servico} REMOVIDO SEM NENHUM PROBLEMA!";
                    responseApi.Status = EnumHttp.SUCESSO.ToString();
                    responseApi.Notifications = entity.Notifications.ToList();

                }
                else
                {
                    responseApi.Mensagem = $"PROBLEMA AO REMOVERR {servico}!";
                    responseApi.Codigo = EnumHttp.ERRO_SERVIDOR;
                    responseApi.Descricao = $"{servico} COM PROBLEMA AO REALIZAR REMOÇÃO!";
                    responseApi.Status = EnumHttp.SUCESSO.ToString();
                    responseApi.Notifications = new List<Notification>();
                    responseApi.Notifications.Add(notificacao);
                }
            }
            return responseApi;
        }
        public TEntity GetById(Guid id)
        {
            return _repositoryBase.GetById(id);
        }
        public ValueTask<TEntity> GetByIdAsync(Guid id)
        {
            return _repositoryBase.GetByIdAsync(id);
        }
        public List<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }
        public Task<List<TEntity>> GetAllAsync()
        {
            return _repositoryBase.GetAllAsync();
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }


        public Notification Commit()
        {
            return _repositoryBase.Commit();
        }
        public Task<int> CommitAsync() => _repositoryBase.CommitAsync();
    }
}
