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
    public class MovimentoController : ApiBaseController<MovimentoViewModel>
    {
        private readonly IMovimentoAppService _movimentoAppService;

        public MovimentoController(ILogger<MovimentoViewModel> logger, IMovimentoAppService movimentoAppService) : base(logger)
        {
            this._movimentoAppService = movimentoAppService;
        }

        [HttpGet]
        public ModelTableService<MovimentoViewModel> GetByAnoMes([FromQuery] int ano, [FromQuery] int mes)
        {
            return TryExecute(() =>
            {
                return this._movimentoAppService.GetByAnoMes(ano, mes);
            });
        }

        [HttpGet("{id}")]
        public ModelService<MovimentoViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._movimentoAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<MovimentoViewModel> Post([FromBody] MovimentoViewModel model)
        {
            return TryExecute(() =>
            {
                return this._movimentoAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<MovimentoViewModel> Put(int id, [FromBody] MovimentoViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdMovimento  = id;
                return this._movimentoAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._movimentoAppService .Delete(id);
            });
        }
    }
}