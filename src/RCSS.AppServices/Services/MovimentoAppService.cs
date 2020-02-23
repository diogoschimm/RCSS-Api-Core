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
    public class MovimentoAppService : AppServiceBase, IMovimentoAppService
    {
        private readonly IMovimentoService _movimentoService;

        public MovimentoAppService(IMapper mapper, IUnitOfWork uow, IMovimentoService movimentoService) : base(mapper, uow)
        {
            this._movimentoService = movimentoService;
        }

        public ModelTableService<MovimentoViewModel> GetByAnoMes(int ano, int mes)
        {
            var map = this._mapper.Map<IEnumerable<MovimentoViewModel>>(this._movimentoService.GetByAnoMes(ano, mes));
            return new ModelTableService<MovimentoViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<MovimentoViewModel> GetById(int idMovimento)
        {
            var map = this._mapper.Map<MovimentoViewModel>(this._movimentoService.GetById(idMovimento));
            return new ModelService<MovimentoViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<MovimentoViewModel> Save(MovimentoViewModel model)
        {
            var result = this._movimentoService.Save(this._mapper.Map<Movimento>(model));
            return this.Commit<MovimentoViewModel, Movimento>(result);
        }

        public ModelService<MovimentoViewModel> Update(MovimentoViewModel model)
        {
            var result = this._movimentoService.Update(this._mapper.Map<Movimento>(model));
            return this.Commit<MovimentoViewModel, Movimento>(result);
        }

        public RetornoService Delete(int idMovimento)
        {
            var entity = this._movimentoService.GetById(idMovimento);
            if (entity == null)
                throw new Exception("Movimento não localizado no sistema");

            this._movimentoService.Delete(entity);
            return this.Commit();
        }
    }
}
