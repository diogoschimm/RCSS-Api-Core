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
    public class MovimentoEstoqueController : ApiBaseController<MovimentoEstoqueViewModel>
    {
        private readonly IMovimentoEstoqueAppService _movimentoEstoqueAppService;

        public MovimentoEstoqueController(ILogger<MovimentoEstoqueViewModel> logger, IMovimentoEstoqueAppService movimentoEstoqueAppService) : base(logger)
        {
            this._movimentoEstoqueAppService = movimentoEstoqueAppService;
        }

        [HttpGet]
        public ModelTableService<MovimentoEstoqueViewModel> Get( )
        {
            return TryExecute(() =>
            {
                return this._movimentoEstoqueAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<MovimentoEstoqueViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._movimentoEstoqueAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<MovimentoEstoqueViewModel> Post([FromBody] MovimentoEstoqueViewModel model)
        {
            return TryExecute(() =>
            {
                return this._movimentoEstoqueAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<MovimentoEstoqueViewModel> Put(int id, [FromBody] MovimentoEstoqueViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdMovimentacao = id;
                return this._movimentoEstoqueAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._movimentoEstoqueAppService .Delete(id);
            });
        }
    }
}