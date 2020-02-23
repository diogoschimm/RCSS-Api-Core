using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories;
using RCSS.Infra.Data.Contexts;
using RCSS.Infra.Data.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace RCSS.Infra.Data.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ProjetoRcssContext context) : base(context) { }

        public IEnumerable<Fornecedor> GetAll()
        {
            return this._context.Fornecedor;
        }

        public Fornecedor GetById(int idFornecedor)
        {
            return this._context.Fornecedor.FirstOrDefault(f => f.IdFornecedor == idFornecedor);
        }
    }
}
