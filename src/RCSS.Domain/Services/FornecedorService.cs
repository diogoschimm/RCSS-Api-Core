using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            this._fornecedorRepository = fornecedorRepository;
        }

        public IEnumerable<Fornecedor> GetAll()
        {
            return this._fornecedorRepository.GetAll();
        }

        public Fornecedor GetById(int idFornecedor)
        {
            return this._fornecedorRepository.GetById(idFornecedor);
        }

        public Fornecedor Save(Fornecedor entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._fornecedorRepository.Save(entity);

            return entity;
        }

        public Fornecedor Update(Fornecedor entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._fornecedorRepository.Update(entity);

            return entity;
        }

        public void Delete(Fornecedor entity)
        {
            this._fornecedorRepository.Delete(entity);
        }
    }
}
