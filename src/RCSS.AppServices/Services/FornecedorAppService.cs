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
    public class FornecedorAppService : AppServiceBase, IFornecedorAppService
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorAppService(IMapper mapper, IUnitOfWork uow, IFornecedorService fornecedorService) : base(mapper, uow)
        {
            this._fornecedorService = fornecedorService;
        }
        
        public ModelTableService<FornecedorViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<FornecedorViewModel>>(this._fornecedorService.GetAll());
            return new ModelTableService<FornecedorViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<FornecedorViewModel> GetById(int idFornecedor)
        {
            var map = this._mapper.Map<FornecedorViewModel>(this._fornecedorService.GetById(idFornecedor));
            return new ModelService<FornecedorViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<FornecedorViewModel> Save(FornecedorViewModel model)
        {
            var result = this._fornecedorService.Save(this._mapper.Map<Fornecedor>(model));
            return this.Commit<FornecedorViewModel, Fornecedor>(result);
        }

        public ModelService<FornecedorViewModel> Update(FornecedorViewModel model)
        {
            var result = this._fornecedorService.Update(this._mapper.Map<Fornecedor>(model));
            return this.Commit<FornecedorViewModel, Fornecedor>(result);
        }

        public RetornoService Delete(int idFornecedor)
        {
            var entity = this._fornecedorService.GetById(idFornecedor);
            if (entity == null)
                throw new Exception("Fornecedor não localizado no sistema");

            this._fornecedorService.Delete(entity);
            return this.Commit();
        }
    }
}
