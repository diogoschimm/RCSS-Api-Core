using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RCSS.ApiDados.Controllers.Base;
using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces;
using RCSS.AppServices.ViewModels;

namespace RCSS.ApiDados.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    [Authorize]
    public class CentroCustoController : ApiBaseController<CentroCustoViewModel>
    {
        private readonly ICentroCustoAppService _centroCustoAppService;

        public CentroCustoController(ILogger<CentroCustoViewModel> logger, ICentroCustoAppService centroCustoAppService) : base(logger)
        {
            this._centroCustoAppService = centroCustoAppService;
        }

        [HttpGet]
        public ModelTableService<CentroCustoViewModel> Get()
        {
            return TryExecute(() =>
            {
                return this._centroCustoAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<CentroCustoViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._centroCustoAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<CentroCustoViewModel> Post([FromBody] CentroCustoViewModel model)
        {
            return TryExecute(() =>
            {
                return this._centroCustoAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<CentroCustoViewModel> Put(int id, [FromBody] CentroCustoViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdCentroCusto = id;
                return this._centroCustoAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._centroCustoAppService.Delete(id);
            });
        }
    }
}
