using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class ItemMovimentoController : ApiBaseController<ItemMovimentoViewModel>
    {
        private readonly IItemMovimentoAppService _itemMovimentoAppService;

        public ItemMovimentoController(ILogger<ItemMovimentoViewModel> logger, IItemMovimentoAppService itemMovimentoAppService) : base(logger)
        {
            this._itemMovimentoAppService = itemMovimentoAppService;
        }

        [HttpGet]
        public ModelTableService<ItemMovimentoViewModel> GetByMovimento([FromQuery] int idMovimento)
        {
            return TryExecute(() =>
            {
                return this._itemMovimentoAppService.GetByMovimento(idMovimento);
            });
        }

        [HttpGet("{id}")]
        public ModelService<ItemMovimentoViewModel> Get(int id)
        {
            return TryExecute(() =>
            {
                return this._itemMovimentoAppService.GetById(id);
            });
        }

        [HttpPost]
        public ModelService<ItemMovimentoViewModel> Post([FromBody] ItemMovimentoViewModel model)
        {
            return TryExecute(() =>
            {
                return this._itemMovimentoAppService.Save(model);
            });
        }

        [HttpPut("{id}")]
        public ModelService<ItemMovimentoViewModel> Put(int id, [FromBody] ItemMovimentoViewModel model)
        {
            return TryExecute(() =>
            {
                model.IdItemMovimento = id;
                return this._itemMovimentoAppService.Update(model);
            });
        }

        [HttpDelete("{id}")]
        public RetornoService Delete(int id)
        {
            return TryExecute(() =>
            {
                return this._itemMovimentoAppService.Delete(id);
            });
        }
    }
}