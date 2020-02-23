using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Produto> GetAll()
        {
            return this._context.Produto;
        }

        public Produto GetById(int idProduto)
        {
            return this._context.Produto.FirstOrDefault(p => p.IdProduto == idProduto);
        }
    }
}
