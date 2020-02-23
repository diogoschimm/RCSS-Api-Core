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
    public class CentroCustoAppService : AppServiceBase, ICentroCustoAppService
    {
        private readonly ICentroCustoService _centroCustoService;

        public CentroCustoAppService(IMapper mapper, IUnitOfWork uow, ICentroCustoService centroCustoService) : base(mapper, uow)
        {
            this._centroCustoService = centroCustoService;
        }

        public ModelTableService<CentroCustoViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<CentroCustoViewModel>>(this._centroCustoService.GetAll());
            return new ModelTableService<CentroCustoViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<CentroCustoViewModel> GetById(int idCentroCusto)
        {
            var map = this._mapper.Map<CentroCustoViewModel>(this._centroCustoService.GetById(idCentroCusto));
            return new ModelService<CentroCustoViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<CentroCustoViewModel> Save(CentroCustoViewModel model)
        {
            var result = this._centroCustoService.Save(this._mapper.Map<CentroCusto>(model));
            return this.Commit<CentroCustoViewModel, CentroCusto>(result);
        }

        public ModelService<CentroCustoViewModel> Update(CentroCustoViewModel model)
        {
            var result = this._centroCustoService.Update(this._mapper.Map<CentroCusto>(model));
            return this.Commit<CentroCustoViewModel, CentroCusto>(result);
        }

        public RetornoService Delete(int idCentroCusto)
        {
            var entity = this._centroCustoService.GetById(idCentroCusto);
            if (entity == null)
                throw new Exception("Centro de Custo não localizado no sistema");

            this._centroCustoService.Delete(entity);
            return this.Commit();
        }
    }
}
