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
    public class FornecedorController : ApiBaseController<FornecedorViewModel>
    {
        private readonly IFornecedorAppService _fornecedorAppService;

        public FornecedorController(ILogger<FornecedorViewModel> logger, IFornecedorAppService fornecedorAppService) : base(logger)
        {
            this._fornecedorAppService = fornecedorAppService;
        }

        [HttpGet]
        public ModelTableService<FornecedorViewModel> Get()
        {
            return TryExecute(() =>
            {
                return this._fornecedorAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<FornecedorViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._fornecedorAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<FornecedorViewModel> Post([FromBody] FornecedorViewModel model)
        {
            return TryExecute(() =>
            {
                return this._fornecedorAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<FornecedorViewModel> Put(int id, [FromBody] FornecedorViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdFornecedor = id;
                return this._fornecedorAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._fornecedorAppService.Delete(id);
            });
        }

    }
}