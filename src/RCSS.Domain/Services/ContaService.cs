using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;

        public ContaService(IContaRepository contaRepository)
        {
            this._contaRepository = contaRepository;
        }

        public IEnumerable<Conta> GetAll()
        {
            return this._contaRepository.GetAll();
        }

        public Conta GetById(int idConta)
        {
            return this._contaRepository.GetById(idConta);
        }

        public IEnumerable<Conta> GetContasComArquivo()
        {
            return this._contaRepository.GetContasComArquivo();
        }

        public Conta Save(Conta entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._contaRepository.Save(entity);

            return entity;
        }

        public Conta Update(Conta entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._contaRepository.Update(entity);

            return entity;
        }

        public void Delete(Conta entity)
        {
            this._contaRepository.Delete(entity);
        }
    }
}
