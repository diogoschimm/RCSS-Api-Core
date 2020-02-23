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
    public class MovimentoEstoqueAppService : AppServiceBase, IMovimentoEstoqueAppService
    {
        private readonly IMovimentoEstoqueService _movimentoEstoqueService;

        public MovimentoEstoqueAppService(IMapper mapper, IUnitOfWork uow, IMovimentoEstoqueService movimentoEstoqueService) : base(mapper, uow)
        {
            this._movimentoEstoqueService = movimentoEstoqueService;
        }

        public ModelTableService<MovimentoEstoqueViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<MovimentoEstoqueViewModel>>(this._movimentoEstoqueService.GetAll() );
            return new ModelTableService<MovimentoEstoqueViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<MovimentoEstoqueViewModel> GetById(int idMovimentacao)
        {
            var map = this._mapper.Map<MovimentoEstoqueViewModel>(this._movimentoEstoqueService.GetById(idMovimentacao));
            return new ModelService<MovimentoEstoqueViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<MovimentoEstoqueViewModel> Save(MovimentoEstoqueViewModel model)
        {
            var result = this._movimentoEstoqueService.Save(this._mapper.Map<MovimentoEstoque>(model));
            return this.Commit<MovimentoEstoqueViewModel, MovimentoEstoque>(result);
        }

        public ModelService<MovimentoEstoqueViewModel> Update(MovimentoEstoqueViewModel model)
        {
            var result = this._movimentoEstoqueService.Update(this._mapper.Map<MovimentoEstoque>(model));
            return this.Commit<MovimentoEstoqueViewModel, MovimentoEstoque>(result);
        }

        public RetornoService Delete(int idMovimentacao)
        {
            var entity = this._movimentoEstoqueService.GetById(idMovimentacao);
            if (entity == null)
                throw new Exception("Movimento de Estoque não localizado no sistema");

            this._movimentoEstoqueService.Delete(entity);
            return this.Commit();
        }
    }
}
