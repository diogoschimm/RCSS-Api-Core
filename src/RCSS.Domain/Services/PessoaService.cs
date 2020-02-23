using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            this._pessoaRepository = pessoaRepository;
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return this._pessoaRepository.GetAll();
        }

        public Pessoa GetById(int idPessoa)
        {
            return this._pessoaRepository.GetById(idPessoa);
        }

        public Pessoa Save(Pessoa entity)
        { 
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._pessoaRepository.Save(entity);

            return entity;
        }

        public Pessoa Update(Pessoa entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._pessoaRepository.Update(entity);

            return entity;
        }

        public void Delete(Pessoa entity)
        {
            this._pessoaRepository.Delete(entity);
        }
    }
}
