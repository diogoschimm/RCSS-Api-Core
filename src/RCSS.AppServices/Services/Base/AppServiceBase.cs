using AutoMapper;
using RCSS.AppServices.Dtos;
using RCSS.Domain.Interfaces.UnitOfWork;
using System.Linq;

namespace RCSS.AppServices.Services.Base
{
    public abstract class AppServiceBase
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _uow;

        protected AppServiceBase(IMapper mapper, IUnitOfWork uow)
        {
            this._mapper = mapper;
            this._uow = uow;
        }

        protected ModelService<TViewModel> Commit<TViewModel, TDomain>(TDomain domainEntity) 
            where TViewModel : class 
            where TDomain : class
        {
            var uowResult = this._uow.Commit();

            var modelService = new ModelService<TViewModel>
            {
                Sucesso = uowResult.Sucesso
            };
            uowResult.Mensagens.ToList().ForEach(msg => modelService.Mensagens.Add(msg));

            if (uowResult.Sucesso)
                modelService.Model = this._mapper.Map<TViewModel>(domainEntity);

            return modelService;
        }

        protected RetornoService Commit()
        {
            var uowResult = this._uow.Commit();

            var retornoService = new RetornoService
            {
                Sucesso = uowResult.Sucesso
            };
            uowResult.Mensagens.ToList().ForEach(msg => retornoService.Mensagens.Add(msg));

            return retornoService;
        }
    }
}
