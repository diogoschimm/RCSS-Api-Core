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
using System.Text;

namespace RCSS.AppServices.Services
{
    public class ProdutoAppService : AppServiceBase, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;
        public ProdutoAppService(IMapper mapper, IUnitOfWork uow, IProdutoService produtoService) : base(mapper, uow)
        {
            this._produtoService = produtoService;
        }
        
        public ModelTableService<ProdutoViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<ProdutoViewModel>>(this._produtoService.GetAll());
            return new ModelTableService<ProdutoViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<ProdutoViewModel> GetById(int idProduto)
        {
            var map = this._mapper.Map<ProdutoViewModel>(this._produtoService.GetById(idProduto));
            return new ModelService<ProdutoViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<ProdutoViewModel> Save(ProdutoViewModel model)
        {
            var result = this._produtoService.Save(this._mapper.Map<Produto>(model));
            return this.Commit<ProdutoViewModel, Produto>(result);
        }

        public ModelService<ProdutoViewModel> Update(ProdutoViewModel model)
        {
            var result = this._produtoService.Update(this._mapper.Map<Produto>(model));
            return this.Commit<ProdutoViewModel, Produto>(result);
        }

        public RetornoService Delete(int idProduto)
        {
            var entity = this._produtoService.GetById(idProduto);
            if (entity == null)
                throw new Exception("Produto não localizado no sistema");

            this._produtoService.Delete(entity);
            return this.Commit();
        }
    }
}
