using AutoMapper;
using RCSS.AppServices.Dtos;
using RCSS.AppServices.Interfaces;
using RCSS.AppServices.Services.Base;
using RCSS.AppServices.ViewModels;
using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Services;
using RCSS.Domain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace RCSS.AppServices.Services
{
    public class PessoaAppService : AppServiceBase, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;
        public PessoaAppService(IMapper mapper, IUnitOfWork uow, IPessoaService pessoaService) : base(mapper, uow)
        {
            this._pessoaService = pessoaService;
        }

        public ModelTableService<PessoaViewModel> GetAll()
        {
            var map = this._mapper.Map<IEnumerable<PessoaViewModel>>(this._pessoaService.GetAll());
            return new ModelTableService<PessoaViewModel>
            {
                Sucesso = true,
                Lista = map.ToList(),
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<PessoaViewModel> GetById(int idPessoa)
        {
            var map = this._mapper.Map<PessoaViewModel>(this._pessoaService.GetById(idPessoa));
            return new ModelService<PessoaViewModel>
            {
                Sucesso = true,
                Model = map,
                Mensagens = { "Operação realizada com sucesso" }
            };
        }

        public ModelService<PessoaViewModel> Save(PessoaViewModel model)
        {
            var result = this._pessoaService.Save(this._mapper.Map<Pessoa>(model));
            return this.Commit<PessoaViewModel, Pessoa>(result);
        }

        public ModelService<PessoaViewModel> Update(PessoaViewModel model)
        {
            var result = this._pessoaService.Update(this._mapper.Map<Pessoa>(model));
            return this.Commit<PessoaViewModel, Pessoa>(result);
        }

        public RetornoService Delete(int idPessoa)
        {
            var entity = this._pessoaService.GetById(idPessoa);
            if (entity == null)
                throw new Exception("Pessoa não localizada no sistema");

            this._pessoaService.Delete(entity);
            return this.Commit();
        }

    }
}
