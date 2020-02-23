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
    public class ContaController : ApiBaseController<ContaViewModel>
    {
        private readonly IContaAppService _contaAppService;

        public ContaController(ILogger<ContaViewModel> logger, IContaAppService contaAppService) : base(logger)
        {
            this._contaAppService = contaAppService;
        }

        [HttpGet]
        public ModelTableService<ContaViewModel> Get()
        {
            return TryExecute(() =>
            {
                return this._contaAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<ContaViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._contaAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<ContaViewModel> Post([FromBody] ContaViewModel model)
        {
            return TryExecute(() =>
            {
                return this._contaAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<ContaViewModel> Put(int id, [FromBody] ContaViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdConta = id;
                return this._contaAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._contaAppService.Delete(id);
            });
        }
    }
}