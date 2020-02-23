using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RCSS.AppServices.Dtos;
using System;

namespace RCSS.ApiDados.Controllers.Base
{
    public abstract class ApiBaseController<T> : ControllerBase
    {
        protected readonly ILogger<T> _logger;

        public ApiBaseController(ILogger<T> logger)
        {
            this._logger = logger;
        }

        protected TModelService TryExecute<TModelService>(DActionResolve<TModelService> resolve)
            where TModelService : RetornoService, new()
        {
            try
            {
                return resolve();
            }
            catch (Exception ex)
            {
                return TratarExcecao<TModelService>(ex);
            }
        }

        private TModelService TratarExcecao<TModelService>(Exception ex) where TModelService : RetornoService, new()
        {
            var retornoService = new TModelService
            {
                Sucesso = false
            };
            retornoService.Mensagens.Add(ex.Message);
            if (ex.InnerException != null)
                retornoService.Mensagens.Add(ex.InnerException.Message);

            return retornoService;
        }
    }

    public delegate TModelService DActionResolve<TModelService>() where TModelService : class;
}