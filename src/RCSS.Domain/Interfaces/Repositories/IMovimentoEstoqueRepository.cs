using RCSS.Domain.Entities;
using RCSS.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace RCSS.Domain.Interfaces.Repositories
{
    public interface IMovimentoEstoqueRepository : IRepositoryBase<MovimentoEstoque>
    {
        IEnumerable<MovimentoEstoque> GetAll();
        MovimentoEstoque GetById(int idMovimentacao);
    }
}
