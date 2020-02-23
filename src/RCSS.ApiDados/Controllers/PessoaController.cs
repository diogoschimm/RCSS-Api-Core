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
    public class PessoaController : ApiBaseController<PessoaViewModel>
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoaController(ILogger<PessoaViewModel> logger, IPessoaAppService pessoaAppService) : base(logger)
        {
            this._pessoaAppService = pessoaAppService;
        }

        [HttpGet]
        public ModelTableService<PessoaViewModel> Get()
        {
            return TryExecute(() =>
            {
                return this._pessoaAppService.GetAll();
            });
        }

        [HttpGet("{id}")]
        public ModelService<PessoaViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._pessoaAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<PessoaViewModel> Post([FromBody] PessoaViewModel model)
        {
            return TryExecute(() =>
            {
                return this._pessoaAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<PessoaViewModel> Put(int id, [FromBody] PessoaViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdPessoa  = id;
                return this._pessoaAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._pessoaAppService.Delete(id);
            });
        }
    }
}