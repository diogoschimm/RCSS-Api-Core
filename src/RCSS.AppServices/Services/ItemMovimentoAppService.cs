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
    public class ItemMovimentoAppService : AppServiceBase, IItemMovimentoAppService
    {
        private readonly IItemMovimentoService _itemMovimentoService;

        public ItemMovimentoAppService(IMapper mapper, IUnitOfWork uow, IItemMovimentoService itemMovimentoService) : base(mapper, uow)
        {
            this._itemMovimentoService = itemMovimentoService;
        }

        public ModelService<ItemMovimentoViewModel> GetById(int idItemMovimento)
        {
            var map = this._mapper.Map<ItemMovimentoViewModel>(this._itemMovimentoService.GetById(idItemMovimento));
            return new ModelService<ItemMovimentoViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelTableService<ItemMovimentoViewModel> GetByMovimento(int idMovimento)
        {
            var map = this._mapper.Map<IEnumerable<ItemMovimentoViewModel>>(this._itemMovimentoService.GetByMovimento(idMovimento));
            return new ModelTableService<ItemMovimentoViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<ItemMovimentoViewModel> Save(ItemMovimentoViewModel model)
        {
            var result = this._itemMovimentoService.Save(this._mapper.Map<ItemMovimento>(model));
            return this.Commit<ItemMovimentoViewModel, ItemMovimento>(result);
        }

        public ModelService<ItemMovimentoViewModel> Update(ItemMovimentoViewModel model)
        {
            var result = this._itemMovimentoService.Update(this._mapper.Map<ItemMovimento>(model));
            return this.Commit<ItemMovimentoViewModel, ItemMovimento>(result);
        }

        public RetornoService Delete(int idItemMovimento)
        {
            var entity = this._itemMovimentoService.GetById(idItemMovimento);
            if (entity == null)
                throw new Exception("Item de Movimento não localizado no sistema");

            this._itemMovimentoService.Delete(entity);
            return this.Commit();
        }
    }
}
