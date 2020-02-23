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
    public class ArquivoController : ApiBaseController<ArquivoViewModel>
    {
        private readonly IArquivoAppService _arquivoAppService;

        public ArquivoController(ILogger<ArquivoViewModel> logger, IArquivoAppService arquivoAppService) : base(logger)
        {
            this._arquivoAppService = arquivoAppService;
        }

        [HttpGet]
        public ModelTableService<ArquivoViewModel> Get()
        {
            return TryExecute(() =>
            {
                return this._arquivoAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<ArquivoViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._arquivoAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<ArquivoViewModel> Post([FromBody] ArquivoViewModel model)
        {
            return TryExecute(() =>
            {
                return this._arquivoAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<ArquivoViewModel> Put(int id, [FromBody] ArquivoViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdArquivo = id;
                return this._arquivoAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._arquivoAppService.Delete(id);
            });
        }
    }
}
