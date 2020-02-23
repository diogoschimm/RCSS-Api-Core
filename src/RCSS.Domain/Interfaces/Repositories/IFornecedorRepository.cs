using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IFornecedorRepository : IRepositoryBase<Fornecedor>
    {
        IEnumerable<Fornecedor> GetAll();
        Fornecedor GetById(int idFornecedor);
    }
}
