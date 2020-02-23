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
    public class ProdutoController : ApiBaseController<ProdutoViewModel>
    {
        private readonly IProdutoAppService _produtoAppService;

        public ProdutoController(ILogger<ProdutoViewModel> logger, IProdutoAppService produtoAppService) : base(logger)
        {
            this._produtoAppService = produtoAppService;
        }

        [HttpGet]
        public ModelTableService<ProdutoViewModel> Get()
        {
            return TryExecute(() =>
            {
                return this._produtoAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<ProdutoViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._produtoAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<ProdutoViewModel> Post([FromBody] ProdutoViewModel model)
        {
            return TryExecute(() =>
            {
                return this._produtoAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<ProdutoViewModel> Put(int id, [FromBody] ProdutoViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdProduto = id;
                return this._produtoAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._produtoAppService.Delete(id);
            });
        }
    }
}