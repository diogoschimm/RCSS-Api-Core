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
    public class ArquivoAppService : AppServiceBase, IArquivoAppService
    {
        private readonly IArquivoService _arquivoService;

        public ArquivoAppService(IMapper mapper, IUnitOfWork uow, IArquivoService arquivoService) : base(mapper, uow)
        {
            this._arquivoService = arquivoService;
        }

        public ModelTableService<ArquivoViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<ArquivoViewModel>>(this._arquivoService.GetAll());
            return new ModelTableService<ArquivoViewModel>
            {
                Sucesso = true,
                Lista = map.ToList()
            };
        }

        public ModelService<ArquivoViewModel> GetById(int idArquivo)
        {
            var map = this._mapper.Map<ArquivoViewModel>(this._arquivoService.GetById(idArquivo));
            return new ModelService<ArquivoViewModel>
            {
                Sucesso = true,
                Model = map
            };
        }

        public ModelService<ArquivoViewModel> Save(ArquivoViewModel model)
        {
            var result = this._arquivoService.Save(this._mapper.Map<Arquivo>(model));
            return this.Commit<ArquivoViewModel, Arquivo>(result);
        }

        public ModelService<ArquivoViewModel> Update(ArquivoViewModel model)
        {
            var result = this._arquivoService.Update(this._mapper.Map<Arquivo>(model));
            return this.Commit<ArquivoViewModel, Arquivo>(result);
        }

        public RetornoService Delete(int idArquivo)
        {
            var entity = this._arquivoService.GetById(idArquivo);
            if (entity == null)
                throw new Exception("Arquivo não localizado no sistema");

            this._arquivoService.Delete(entity);
            return this.Commit();
        }
    }
}
