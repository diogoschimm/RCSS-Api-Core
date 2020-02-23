using AutoMapper;
using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces;
using RCSS.AppServices.Services.Base;
using RCSS.AppServices.ViewModels;
using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services;
using RCSS.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.AppServices.Services
{
    public class ContaAppService : AppServiceBase, IContaAppService
    {
        private readonly IContaService _contaService;

        public ContaAppService(IMapper mapper, IUnitOfWork uow, IContaService contaService) : base(mapper, uow)
        {
            this._contaService = contaService;
        }
         
        public ModelTableService<ContaViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<ContaViewModel>>(this._contaService.GetAll());
            return new ModelTableService<ContaViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<ContaViewModel> GetById(int idConta)
        {
            var map = this._mapper.Map<ContaViewModel>(this._contaService.GetById(idConta));
            return new ModelService<ContaViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelTableService<ContaViewModel> GetContasComArquivo()
        {
            var map = this._mapper.Map<IEnumerable<ContaViewModel>>(this._contaService.GetContasComArquivo());
            return new ModelTableService<ContaViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<ContaViewModel> Save(ContaViewModel model)
        {
            var result = this._contaService.Save(this._mapper.Map<Conta>(model));
            return this.Commit<ContaViewModel, Conta>(result);
        }

        public ModelService<ContaViewModel> Update(ContaViewModel model)
        {
            var result = this._contaService.Update(this._mapper.Map<Conta>(model));
            return this.Commit<ContaViewModel, Conta>(result);
        }

        public RetornoService Delete(int idConta)
        {
            var entity = this._contaService.GetById(idConta);
            if (entity == null)
                throw new Exception("Conta não localizada no sistema");

            this._contaService.Delete(entity);
            return this.Commit();
        }
    }
}
