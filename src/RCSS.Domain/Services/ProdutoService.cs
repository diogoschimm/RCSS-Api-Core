using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace RCSS.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetAll()
        {
            return this._produtoRepository.GetAll();
        }

        public Produto GetById(int idProduto)
        {
            return this._produtoRepository.GetById(idProduto);
        }

        public Produto Save(Produto entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._produtoRepository.Save(entity);

            return entity;
        }

        public Produto Update(Produto entity)
        {
            if (!entity.Validar())
                return entity;

            if (entity.Valid)
                this._produtoRepository.Update(entity);

            return entity;
        }

        public void Delete(Produto entity)
        {
            this._produtoRepository.Delete(entity);
        }
    }
}
